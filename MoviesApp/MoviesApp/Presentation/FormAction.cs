using MoviesApp.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using MoviesApp.Data.Model;
using MoviesApp.Resources;

namespace MoviesApp.Presentation
{
    public partial class FormAction : Form
    {
        public List<PictureBox> filmPictureBoxes;
        public FormAction()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.myForm.Show();
        }
        MovieBusiness mb = new MovieBusiness();
        bool isNextPageButtonClickled = false;
        bool isPreviousPageButtonClicked = false;
        bool canOpenPage = true;
        bool canReturnPage = false;
        int countMoviesOnPage = 10;
        int indexImage = 1;
        int countMoviesToLoad;
        int countPages;
        int index;
        private void FormAction_Load(object sender, EventArgs e)
        {
            if (mb.FindMoviesFromGenre(MovieInformation.IndexGenre).Count < 10)
            {
                pictureBox2.Visible = false;
            }
            countPages = mb.FindMoviesFromGenre(MovieInformation.IndexGenre).Count/10;
            this.CenterToScreen();
            ShowImages(MovieInformation.IndexGenre, MovieInformation.GenreLetter);
        }

        private void ShowImages(int genreId, string genreLetter)
        {

            filmPictureBoxes = new List<PictureBox>();

            int locationImageX = 40;
            int locationImageY = 100;
            int locationTextX = 40;
            int locationTextY = 260;
            countMoviesToLoad = mb.FindMoviesFromGenre(genreId).Count;

            if (countMoviesToLoad < 10)
            {
                countMoviesOnPage = countMoviesToLoad;
            }

            if (isNextPageButtonClickled)
            {
                canOpenPage = true;
            }
            if (isPreviousPageButtonClicked)
            {
               canReturnPage = true;
            }
            if (canOpenPage)
            {
                for (int i = 1; i <= countMoviesOnPage; i++)
                {
                    string fileName = $"fotos{genreLetter}\\{genreLetter}{indexImage}.jpg";
                    PictureBox pictureBoxAction = new PictureBox();
                    pictureBoxAction.Name = $"{genreLetter}{indexImage}";
                    pictureBoxAction.Image = Image.FromFile(fileName);
                    pictureBoxAction.Location = new Point(locationImageX, locationImageY);
                    pictureBoxAction.Size = new Size(150, 150);
                    pictureBoxAction.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxAction.Parent = this;
                    pictureBoxAction.Visible = true;
                    pictureBoxAction.BringToFront();
                    locationImageX += 160;
                    Movie movie = mb.FindMoviesFromGenre(genreId)[indexImage - 1];
                    int indexer = indexImage;
                    pictureBoxAction.Click += (s, e) =>
                    {
                        MovieInformation.IndexMovie = indexer;
                        MovieInformation.LetterMovie = genreLetter;

                        MovieInformation.formAction = this;
                        var film = new Film(movie);
                        MovieInformation.film = film;
                        MovieInformation.film.Show();
                        this.Hide();
                    };

                    filmPictureBoxes.Add(pictureBoxAction);

                    Label label = new Label();
                    label.Name = $"{genreLetter}{indexImage}";
                    label.Location = new Point(locationTextX, locationTextY);
                    label.Size = new Size(150, 50);
                    label.Parent = this;
                    label.Visible = true;
                    label.BringToFront();
                    label.Text = mb.FindMoviesFromGenre(genreId)[indexImage - 1].MovieTitle;
                    label.TextAlign = ContentAlignment.TopCenter;
                    locationTextX += 160;


                    if (locationImageX > 700)
                    {
                        locationImageY += 200;
                        locationImageX = 40;
                        locationTextY = locationImageY + 160;
                        locationTextX = 40;
                    }
                    canOpenPage = false;
                    isNextPageButtonClickled = false;
                    indexImage++;
                }//show images next 
                for (int i = 1; i <= 10 - countMoviesOnPage; i++)
                {
                    //string fileName = $"fotos{genreLetter}\\{genreLetter}{indexImage}.jpg";
                    PictureBox pictureBoxAction = new PictureBox();
                    pictureBoxAction.Name = $"empty{indexImage}";
                    //pictureBoxAction.Image = Image.FromFile(fileName);
                    pictureBoxAction.Location = new Point(locationImageX, locationImageY);
                    pictureBoxAction.Size = new Size(150, 150);
                    //  pictureBoxAction.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxAction.Parent = this;
                    pictureBoxAction.Visible = true;
                    pictureBoxAction.BringToFront();
                    locationImageX += 160;
                    // Movie movie = mb.FindMoviesFromGenre(genreId)[indexImage - 1];
                    //int indexer = indexImage;   

                    filmPictureBoxes.Add(pictureBoxAction);

                    Label label = new Label();
                    label.Name = $"empty{indexImage}";
                    label.Location = new Point(locationTextX, locationTextY);
                    label.Size = new Size(150, 50);
                    label.Parent = this;
                    label.Visible = true;
                    label.BringToFront();
                    //label.Text = mb.FindMoviesFromGenre(genreId)[indexImage - 1].MovieTitle;
                    //label.TextAlign = ContentAlignment.TopCenter;
                    locationTextX += 160;


                    if (locationImageX > 700)
                    {
                        locationImageY += 200;
                        locationImageX = 40;
                        locationTextY = locationImageY + 160;
                        locationTextX = 40;
                    }
                }//show images empty
                countMoviesToLoad -= 10;
                if (countMoviesToLoad < 10 && countMoviesToLoad > 0)
                {
                    countMoviesOnPage = countMoviesToLoad;
                }
            }
            countMoviesToLoad -= 10;
            if (canReturnPage)//show images previous
            {
                 locationImageX = 40;
                 locationImageY = 100;
                 locationTextX = 40;
                 locationTextY = 260;

                index = indexImage - countMoviesOnPage;
                for (int i = index-10; i < index; i++)
                {
                    string fileName = $"fotos{genreLetter}\\{genreLetter}{i}.jpg";
                    PictureBox pictureBoxAction = new PictureBox();
                    pictureBoxAction.Name = $"{genreLetter}{indexImage}";
                    pictureBoxAction.Image = Image.FromFile(fileName);
                    pictureBoxAction.Location = new Point(locationImageX, locationImageY);
                    pictureBoxAction.Size = new Size(150, 150);
                    pictureBoxAction.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxAction.Parent = this;
                    pictureBoxAction.Visible = true;
                    pictureBoxAction.BringToFront();
                    locationImageX += 160;
                    //Movie movie = mb.FindMoviesFromGenre(genreId)[indexImage - 1];
                    //int indexer = indexImage;
                    //pictureBoxAction.Click += (s, e) =>
                    //{
                    //    MovieInformation.IndexMovie = indexer;
                    //    MovieInformation.LetterMovie = genreLetter;

                    //    MovieInformation.formAction = this;
                    //    var film = new Film(movie);
                    //    MovieInformation.film = film;
                    //    MovieInformation.film.Show();
                    //    this.Hide();
                    //};

                    //filmPictureBoxes.Add(pictureBoxAction);

                    //Label label = new Label();
                    //label.Name = $"{genreLetter}{indexImage}";
                    //label.Location = new Point(locationTextX, locationTextY);
                    //label.Size = new Size(150, 50);
                    //label.Parent = this;
                    //label.Visible = true;
                    //label.BringToFront();
                    //label.Text = mb.FindMoviesFromGenre(genreId)[indexImage - 1].MovieTitle;
                    //label.TextAlign = ContentAlignment.TopCenter;
                    //locationTextX += 160;


                    if (locationImageX > 700)
                    {
                        locationImageY += 200;
                        locationImageX = 40;
                        locationTextY = locationImageY + 160;
                        locationTextX = 40;
                    }
                    canOpenPage = false;
                    isNextPageButtonClickled = false;
                    indexImage--;
                }//show prevo
            }
        }



        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox2.BringToFront();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox1.BringToFront();
        }

        private void FormAction_MouseEnter(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }



        private void button6_Click(object sender, EventArgs e)//екшън
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 1;
            MovieInformation.GenreLetter = "A";
            formAction.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)//приключенски
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 2;
            MovieInformation.GenreLetter = "Adv";
            formAction.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)//комедии
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 3;
            MovieInformation.GenreLetter = "Comedy";
            formAction.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)//криминални
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 4;
            MovieInformation.GenreLetter = "Criminal";
            formAction.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)//фентъзи
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 5;
            MovieInformation.GenreLetter = "Fantasy";
            formAction.Show();
            this.Hide();
        }
        private void button11_Click(object sender, EventArgs e)//научна фантастика
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 6;
            MovieInformation.GenreLetter = "Sci";
            formAction.Show();
            this.Hide();
        }
        private void button12_Click(object sender, EventArgs e)//исторически
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 7;
            MovieInformation.GenreLetter = "History";
            formAction.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)//ужаси
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 8;
            MovieInformation.GenreLetter = "Horror";
            formAction.Show();
            this.Hide();
        }
        private void button14_Click(object sender, EventArgs e)//романтика
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 9;
            MovieInformation.GenreLetter = "Romance";
            formAction.Show();
        }
        private void button15_Click(object sender, EventArgs e)//трилър
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 10;
            MovieInformation.GenreLetter = "Thriller";
            formAction.Show();
            this.Hide();
        }
        private void button16_Click(object sender, EventArgs e)//анимация детско
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 11;
            MovieInformation.GenreLetter = "Cartoon";
            formAction.Show();
            this.Hide();
        }
        private void button17_Click(object sender, EventArgs e)//драма
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 12;
            MovieInformation.GenreLetter = "Drama";
            formAction.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (countMoviesToLoad > 10)
            {
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox2.Visible = false;
            }
            isNextPageButtonClickled = true;
            pictureBox3.Visible = true;
            ShowImages(MovieInformation.IndexGenre, MovieInformation.GenreLetter);
            canReturnPage = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (countPages >= 1)
            {
                if (countMoviesToLoad < 10)
                {
                    pictureBox3.Visible = false;
                }
                else
                {
                    pictureBox3.Visible = false;
                }
                isPreviousPageButtonClicked = true;
                pictureBox2.Visible = true;
                ShowImages(MovieInformation.IndexGenre, MovieInformation.GenreLetter);
                countPages--;
            }
        }
    }
}

