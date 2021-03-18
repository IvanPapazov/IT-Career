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

        private void FormAction_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            ShowImages(MovieInformation.IndexGenre, MovieInformation.GenreLetter);
        }

        private void ShowImages(int genreId, string genreLetter)
        {
            MovieBusiness mb = new MovieBusiness();
            filmPictureBoxes = new List<PictureBox>();

            int locationImageX = 40;
            int locationImageY = 100;
            int locationTextX = 40;
            int locationTextY = 260;

            for (int i = 1; i <= mb.FindMoviesFromGenre(genreId).Count; i++)
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

                pictureBoxAction.Tag = mb.FindMoviesFromGenre(genreId)[i - 1].MovieTitle;
                filmPictureBoxes.Add(pictureBoxAction);

                Label label = new Label();
                label.Name = $"{genreLetter}{i}";
                label.Location = new Point(locationTextX, locationTextY);
                label.Size = new Size(150, 50);
                label.Parent = this;
                label.Visible = true;
                label.BringToFront();
                label.Text = mb.FindMoviesFromGenre(genreId)[i - 1].MovieTitle;
                label.TextAlign = ContentAlignment.TopCenter;
                locationTextX += 160;


                if (locationImageX > 700)
                {
                    locationImageY += 200;
                    locationImageX = 40;
                    locationTextY = locationImageY + 160;
                    locationTextX = 40;
                }

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

        private void buttonPlaylist_Click(object sender, EventArgs e)
        {
            var playlistForm = new PlaylistForm("FormAction");
            playlistForm.Show();
            MovieInformation.formAction = this;
            this.Hide();
        }

        private void buttonDescription_Click(object sender, EventArgs e)
        {
            var formDescription = new DescriptionForm("FormAction");
            MovieInformation.formAction = this;
            formDescription.Show();
            this.Hide();
        }
    }
}

