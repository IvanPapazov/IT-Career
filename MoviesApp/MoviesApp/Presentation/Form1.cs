using System;
using System.Windows.Forms;
using MoviesApp.Business;
using MoviesApp.Data;
using MoviesApp.Data.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MoviesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            EnsureDateBaseIsCreated();          
        }
        Movie movie;
        private void EnsureDateBaseIsCreated()
        {
            MovieBusiness bc = new MovieBusiness();//create database
            if (!bc.CheckIsFulled())
            {
                Director director = new Director("James", "Cameron");
                bc.Add(director);
                Actor actor = new Actor("Leonardo", "Dicaprio", "male");
                bc.Add(actor);
                Genre genre = new Genre("drama");
                bc.Add(genre);
                movie = new Movie("Titanic", 1997, 125, "US", 1, "Watch it");     
                bc.Add(movie);
                Movie movie2 = new Movie("Fast and furious", 2003, 125, "US", 1, "Watch it");
                bc.Add(movie2);
                MovieActor movieActor = new MovieActor(1, 1);
                bc.Add(movieActor);
                MovieGenre movieGenre = new MovieGenre(1,1);
                bc.Add(movieGenre);
                Playlist playList = new Playlist("Oscar films");
                bc.Add(playList);
                MoviePlaylist moviePlaylist = new MoviePlaylist(1,1);
                bc.Add(moviePlaylist);      
            }

            List<Movie> movies = bc.GetAllMovies();
            label1.Text = "";
            foreach (var m in movies)
            {

                label1.Text = label1.Text + " " + m.MovieTitle;
            }

            bc.UpdateLike(movie);
        }
    }
}
