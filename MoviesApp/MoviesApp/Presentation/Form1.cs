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
        private void EnsureDateBaseIsCreated()
        {
            MovieBusiness bc = new MovieBusiness();//create database
            if (!bc.CheckIsFulled())
            {

                List<string> actorList = new List<string> { "Leonardo Leonardo male", "Kati Kati fmale" };
                List<string> genreList = new List<string> { "drama", "actione" };
                string directorString = "James James";
                bc.AddMovieInDatabase(directorString, actorList, genreList, "Anabel", 1997, 125, "US", "Watch it");
            }

        }
    }
}
