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
                Movie movie = new Movie("Titanic", 1997, 125, "US", "Watch it");
                bc.Add(movie);
                Actor actor = new Actor("Leonardo", "Dicaprio", "male");
                bc.Add(actor);
                MovieActor movieActor = new MovieActor(1, 1);
                bc.Add(movieActor);
            }
        }
    }
}
