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
using System.IO;
using System.Diagnostics;

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
        bool canOpenPage = true;//next
        bool canReturnPage = false;//back
        int index;
        int countMoviesOnPage = 10;
        int indexImage = 1;
        int countMoviesToLoad;
        int countPages;
        int countCurrentPage = 0;
        bool isFirstPage = true;
        bool isLastPage = false;
        bool isMiddlePage = false;

        private void FormAction_Load(object sender, EventArgs e)
        {
            

            filmPictureBoxes = new List<PictureBox>();
            countPages = (mb.FindMoviesFromGenre(MovieInformation.IndexGenre).Count / 10);
            if ((mb.FindMoviesFromGenre(MovieInformation.IndexGenre).Count % 10) != 0)
            {
                countPages++;
            }
            countMoviesToLoad = mb.FindMoviesFromGenre(MovieInformation.IndexGenre).Count;
            countCurrentPage++;
            if (countCurrentPage == 1)
            {
                isFirstPage = true;
            }
            if (countCurrentPage == countPages)
            {
                isLastPage = true;
            }

            //defining actions that the user can do
            if (isFirstPage == true && isLastPage == false)//first page 
            {
                pictureBox2.Visible = true;//next
                pictureBox3.Visible = false;//back
                canOpenPage = true;
                canReturnPage = false;
            }
            else if (isFirstPage == true && isLastPage == true)//only 1 page(first and last)
            {
                pictureBox2.Visible = false;//next
                pictureBox3.Visible = false;//back
                canOpenPage = true;
                canReturnPage = false;
            }
            //do the actions
            this.CenterToScreen();
            ShowImages(MovieInformation.IndexGenre, MovieInformation.GenreLetter);
        }

        private void ShowImages(int genreId, string genreLetter)
        {
            int locationImageX = 40;
            int locationImageY = 100;
            int locationTextX = 40;
            int locationTextY = 260;

            if (canOpenPage)
            {
                ShowImagesNext(genreId, genreLetter, locationImageX, locationImageY, locationTextX, locationTextY);
            }
            if (canReturnPage)
            {
                ShowImagesBefore(genreId, genreLetter, locationImageX, locationImageY, locationTextX, locationTextY);
            }
            //MessageBox.Show(indexImage.ToString());
            /*
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
                    indexImage++;
                }

                button5.Text = indexImage.ToString();//show images next 

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
                countMoviesToLoad -= countMoviesOnPage;
                //if (countMoviesToLoad < 10)
                //{
                //    countMoviesOnPage = countMoviesToLoad;
                //}
            }
            //!
            if (canReturnPage)
            {
                locationImageX = 40;
                locationImageY = 100;
                locationTextX = 40;
                locationTextY = 260;

                index = indexImage - countMoviesOnPage;
                for (int i = index - 10; i < index; i++)
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
                }

                indexImage -= (index + countMoviesOnPage - 1);
                button5.Text = indexImage.ToString();
            }//show images previous
            */
        }
        public void ShowImagesNext(int genreId, string genreLetter, int locationImageX, int locationImageY, int locationTextX, int locationTextY)
        {
            if (countMoviesToLoad < 10)//check if the page is last, and loads <10 images on it
            {
                countMoviesOnPage = countMoviesToLoad;
            }

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
                label.Size = new Size(150, 70);
                label.Parent = this;
                label.Visible = true;
                label.BringToFront();
                label.Text = mb.FindMoviesFromGenre(genreId)[indexImage - 1].MovieTitle;
                label.TextAlign = ContentAlignment.TopCenter;
                locationTextX += 160;

                if (locationImageX > 700)
                {
                    locationImageY += 235;
                    locationImageX = 40;
                    locationTextY = locationImageY + 175;
                    locationTextX = 40;
                }
                indexImage++;
            }
            //show images empty
            for (int i = 1; i <= 10 - countMoviesOnPage; i++)
            {
                PictureBox pictureBoxAction = new PictureBox();
                pictureBoxAction.Name = $"empty{indexImage}";
                pictureBoxAction.Location = new Point(locationImageX, locationImageY);
                pictureBoxAction.Size = new Size(150, 150);
                pictureBoxAction.Parent = this;
                pictureBoxAction.Visible = true;
                pictureBoxAction.BringToFront();
                locationImageX += 160;

                filmPictureBoxes.Add(pictureBoxAction);

                Label label = new Label();
                label.Name = $"empty{indexImage}";
                label.Location = new Point(locationTextX, locationTextY);
                label.Size = new Size(150, 70);
                label.Parent = this;
                label.Visible = true;
                label.BringToFront();
                locationTextX += 160;

                if (locationImageX > 700)
                {
                    locationImageY += 235;
                    locationImageX = 40;
                    locationTextY = locationImageY + 175;
                    locationTextX = 40;
                }
            }

            countMoviesToLoad -= countMoviesOnPage;
        }

        public void ShowImagesBefore(int genreId, string genreLetter, int locationImageX, int locationImageY, int locationTextX, int locationTextY)
        {

            index = indexImage - countMoviesOnPage;
            if (countCurrentPage + 1 == countPages)
            {
                indexImage -= countMoviesOnPage;
                countMoviesToLoad += countMoviesOnPage;
            }
            else
            {
                indexImage -= 10;
            }
            countMoviesOnPage = 0;
            for (int i = index - 10; i < index; i++)
            {
                string fileName = $"fotos{genreLetter}\\{genreLetter}{i}.jpg";
                PictureBox pictureBoxAction = new PictureBox();
                pictureBoxAction.Name = $"{genreLetter}{i}";
                pictureBoxAction.Image = Image.FromFile(fileName);
                pictureBoxAction.Location = new Point(locationImageX, locationImageY);
                pictureBoxAction.Size = new Size(150, 150);
                pictureBoxAction.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxAction.Parent = this;
                pictureBoxAction.Visible = true;
                pictureBoxAction.BringToFront();
                locationImageX += 160;


                Movie movie = mb.FindMoviesFromGenre(genreId)[i - 1];

                int indexer = i;
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
                label.Name = $"{genreLetter}{i}";
                label.Location = new Point(locationTextX, locationTextY);
                label.Size = new Size(150, 70);
                label.Parent = this;
                label.Visible = true;
                label.BringToFront();
                label.Text = mb.FindMoviesFromGenre(genreId)[i - 1].MovieTitle;
                label.TextAlign = ContentAlignment.TopCenter;
                locationTextX += 160;

                if (locationImageX > 700)
                {
                    locationImageY += 235;
                    locationImageX = 40;
                    locationTextY = locationImageY + 175;
                    locationTextX = 40;
                }
                countMoviesOnPage++;
            }
            if (countCurrentPage == 1 && countPages > 2)
            {
                countMoviesToLoad += countMoviesOnPage;
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

        private void pictureBox2_Click(object sender, EventArgs e)//NEXT
        {
            //defining what is the NEXT page
            countCurrentPage++;
            isFirstPage = false;
            if (countCurrentPage == countPages)//last page
            {

                isLastPage = true;
                isFirstPage = false;
                isMiddlePage = false;
            }
            if (countCurrentPage > 1 && countCurrentPage < countPages)//middle page
            {
                isMiddlePage = true;
                isFirstPage = false;
                isLastPage = false;
            }

            //defining actions that the user can do

            if (isMiddlePage == true)//middle page
            {
                pictureBox2.Visible = true;//next
                pictureBox3.Visible = true;//back
                canOpenPage = true;
                canReturnPage = false;

                ShowImages(MovieInformation.IndexGenre, MovieInformation.GenreLetter);

            }
            else if (isLastPage == true && isFirstPage == false)//last page
            {
                pictureBox2.Visible = false;//next
                pictureBox3.Visible = true;//back
                //MessageBox.Show("can go next");
                canOpenPage = true;
                canReturnPage = false;

                ShowImages(MovieInformation.IndexGenre, MovieInformation.GenreLetter);
            }
            //MessageBox.Show(indexImage.ToString());
            //do the actions

        }

        private void pictureBox3_Click(object sender, EventArgs e)//BACK
        {
            //defining which is the PREVIOUS page
            countCurrentPage--;
            isLastPage = false;
            if (countCurrentPage == 1)//first page
            {
                isFirstPage = true;
            }
            if (countCurrentPage > 1 && countCurrentPage < countPages)//middle page
            {
                isMiddlePage = true;
            }

            //defining actions that the user can do
            if (isFirstPage == true && isLastPage == false)//first page 
            {
                pictureBox2.Visible = true;//next
                pictureBox3.Visible = false;//back
                canOpenPage = false;
                canReturnPage = true;
                //MessageBox.Show("You can go back");
                ShowImages(MovieInformation.IndexGenre, MovieInformation.GenreLetter);


            }
            else if (isMiddlePage == true)//middle page
            {
                pictureBox2.Visible = true;//next
                pictureBox3.Visible = true;//back
                canOpenPage = false;
                canReturnPage = true;
                ShowImages(MovieInformation.IndexGenre, MovieInformation.GenreLetter);
            }
        }
    }
}

