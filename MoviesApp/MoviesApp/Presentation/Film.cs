using Microsoft.VisualBasic;
using MoviesApp.Business;
using MoviesApp.Data.Model;
using MoviesApp.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MoviesApp.Resources
{
    public partial class Film : Form
    {
        Movie movie;
        MovieBusiness bc = new MovieBusiness();
        string previousForm;
        /// <summary>
        /// Конструктор, приемащ два параметъра
        /// </summary>
        /// <param name="movie"> Обект от филм</param>
        /// <param name="previousForm"> Променлива, пазеща предходната страница</param>
        public Film(Movie movie,string previousForm)
        {
            this.movie = movie;
            this.previousForm = previousForm;
            InitializeComponent();
        }

        /// <summary>
        /// Метод за зареждане на формата
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитията</param>
        /// <param name="e">Данни за събитието</param>
        private void Film_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();

            textBoxTitle.Text = movie.MovieTitle;

            labelYear.Text = movie.MovieYear.ToString();
            labelDuration.Text = movie.Duration.ToString();
            textBoxCountry.Text = movie.MovieCountry.ToString();

            Director director = bc.GetDirector(movie.DirectorId);
            textBoxDirector.Text = director.FirstName + " " + director.LastName;

            List<Actor> actors = bc.FindActorsFromMovie(movie.Id);

            pictureBox2.Visible = false;
            pictureBoxBack.Visible = true;

            foreach (var actor in actors)
            {
                textBoxActors.Text += actor.FirstName + " " + actor.LastName + Environment.NewLine;
            }
            string fileName = $"fotos{MovieInformation.LetterMovie}\\{MovieInformation.LetterMovie}{MovieInformation.IndexMovie}.jpg";
            pictureBox1.Image = Image.FromFile(fileName);

            textBoxDescription.Text = movie.Description;

            if (textBoxDescription.Text.Length > 320)
            {
                pictureBox2.Visible = true;
            }

            if (!movie.IsLiked)
            {
                pictureBoxHeart.Image = Image.FromFile("otherResources\\heart2.png"); //empty      
            }
            else if (movie.IsLiked)
            {
                pictureBoxHeart.Image = Image.FromFile("otherResources\\heart1.png");    //full   
            }
        }

       
        private void button2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Метод, извикващ се при натискане на поле за изображение 2
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(979, 900);
            this.CenterToScreen();
            pictureBox2.Visible = false;
        }

        /// <summary>
        /// Метод, извикващ се при натискане на поле за изображение Назад
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            MovieInformation.film = this; 
            if (previousForm=="Form1")
            {
               Form1 form1 = MovieInformation.form1;
                form1.Show();
            }
            else if (previousForm=="FormAction")
            {
                FormAction formAction = MovieInformation.formAction;
                formAction.Show();
            }
            this.Close();
        }

        private void textBoxActors_TextChanged(object sender, EventArgs e)
        {

        }


        private void labelYear_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelDuration_Click(object sender, EventArgs e)
        {

        }


        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDirector_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Метод, извикващ се при натискане на поле за изображение 1
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "https://filmi7.com",                                                                  //correct link - https://filmi7.com/filmi/3638-titanic-titanik-1997.html
                UseShellExecute = true
            };

            Process.Start(psi);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Метод, извикващ се при натискане на поле за изображение 3
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!movie.IsLiked)
            {
                pictureBoxHeart.Image = Image.FromFile("otherResources\\heart1.png");
                movie.IsLiked = true;
                bc.UpdateLike(movie);
                MoviePlaylist moviePlaylist = new MoviePlaylist(1, movie.Id);
                bc.Add(moviePlaylist);
            }
            else if (movie.IsLiked)
            {
                pictureBoxHeart.Image = Image.FromFile("otherResources\\heart2.png");
                movie.IsLiked = false;
                bc.UpdateDislike(movie);
                bc.DeleteMovieFromPlaylist(1, movie.Id);
            }

        }

        /// <summary>
        /// Метод, извикващ се при навлизане на курсора на мишката в поле за изображение Харесано
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void pictureBoxHeart_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxHeart.Image = Image.FromFile("otherResources\\heart1.png");
        }

        /// <summary>
        /// Метод, извикващ се при излизане на курсора на мишката от поле за изображение Харесано
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void pictureBoxHeart_MouseLeave(object sender, EventArgs e)
        {
            if (!movie.IsLiked)
            {
                pictureBoxHeart.Image = Image.FromFile("otherResources\\heart2.png");
            }

        }

        /// <summary>
        /// Метод, извикващ се при натискане на поле за изображение Плюс
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void pictureBoxPlus_Click_1(object sender, EventArgs e)
        {
            var playlistForm = new AddPlaylistForm(this.movie);
            playlistForm.Show();
        }

        /// <summary>
        /// Метод, извикващ се при зареждане на формата
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void Film_MouseEnter(object sender, EventArgs e)
        {
            if (movie.IsLiked)
            {
                pictureBoxHeart.Image = Image.FromFile("otherResources\\heart1.png");
            }
            else
            {
                pictureBoxHeart.Image = Image.FromFile("otherResources\\heart2.png");
            }
        }

        /// <summary>
        /// Метод, извикващ се при навлизане на курсора на мишката в поле за изображение 1
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxGoLink.Visible = true;
        }

        /// <summary>
        /// Метод, извикващ се при излизане на курсора на мишката от поле за изображение 1
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxGoLink.Visible = false;
        }

        /// <summary>
        /// Метод, служещ за извършване на действие при натискане на изображение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxGoLink_Click(object sender, EventArgs e)
        {
            var psi2 = new ProcessStartInfo
            {
                FileName = "https://filmi7.com",                                                                  //correct link - https://filmi7.com/filmi/3638-titanic-titanik-1997.html
                UseShellExecute = true
            };

            Process.Start(psi2);
        }
    }
}
