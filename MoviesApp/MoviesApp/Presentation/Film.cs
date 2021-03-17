using Microsoft.VisualBasic;
using MoviesApp.Business;
using MoviesApp.Data.Model;
using MoviesApp.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MoviesApp.Resources
{
    public partial class Film : Form
    {
        Movie movie;
        MovieBusiness bc = new MovieBusiness();
       
        public Film(Movie movie)
        {
            this.movie = movie;
            InitializeComponent();
        }

        private void Film_Load(object sender, EventArgs e)
        {
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(979, 900);
            this.CenterToScreen();
            pictureBox2.Visible = false;
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            MovieInformation.film = this;
            FormAction formAction = MovieInformation.formAction;
            formAction.Show();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!movie.IsLiked)
            {
                pictureBoxHeart.Image = Image.FromFile("otherResources\\heart1.png");
                movie.IsLiked = true;
                bc.UpdateLike(movie);
                //MoviePlaylist moviePlaylist = new MoviePlaylist(1, movie.Id);
                //bc.Add(moviePlaylist);        
            }
            else if (movie.IsLiked)
            {
                pictureBoxHeart.Image = Image.FromFile("otherResources\\heart2.png");
                movie.IsLiked = false;
                bc.UpdateDislike(movie);
                //bc.DeleteFilmFromPlaylist(1,movie.Id);
            }
           
        }

        private void pictureBoxHeart_MouseEnter(object sender, EventArgs e)
        {         
            pictureBoxHeart.Image = Image.FromFile("otherResources\\heart1.png");
        }

        private void pictureBoxHeart_MouseLeave(object sender, EventArgs e)
        {
            if (!movie.IsLiked)
            {
                pictureBoxHeart.Image = Image.FromFile("otherResources\\heart2.png");
            }
            
        }
    }
}
