using System;
using System.Windows.Forms;
using MoviesApp.Business;
using MoviesApp.Data;
using MoviesApp.Data.Model;
using Microsoft.EntityFrameworkCore;

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
                Movie movie = new Movie("Titanic", 1997, 125, "US", 1, "Watch it");
                bc.Add(movie);
                MovieActor movieActor = new MovieActor(1, 1);
                bc.Add(movieActor);
                MovieGenre movieGenre = new MovieGenre(1,1);
                bc.Add(movieGenre);
                Playlist playList = new Playlist("Oscar films");
                bc.Add(playList);
                //MoviePlaylist moviePlaylist = new MoviePlaylist(1,1);
                //bc.Add(moviePlaylist);
            }
        }
    }
}
