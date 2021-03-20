﻿using MoviesApp.Business;
using MoviesApp.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoviesApp.Presentation
{
    public partial class AddPlaylistForm : Form
    {
        Movie movie;
        public AddPlaylistForm(Movie movie)
        {
            InitializeComponent();
            this.movie = movie;
            
        }

        MovieBusiness mb = new MovieBusiness();
        Playlist currPlaylist;

        private void dataGridViewPlaylists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dv = dataGridViewPlaylists.Rows[e.RowIndex];
                string playListName = dv.Cells[0].Value.ToString();

                currPlaylist = mb.GetAllPlaylists().Where(p => p.Name == playListName).ToList().FirstOrDefault();

            }
        }
        private void UpdateGrid()
        {
            dataGridViewPlaylists.DataSource = mb.GetAllPlaylists();

            dataGridViewPlaylists.Columns.RemoveAt(0);
            dataGridViewPlaylists.Columns.RemoveAt(1);
            dataGridViewPlaylists.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AddPlaylistForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            UpdateGrid();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            List<MoviePlaylist> moviePlaylists = mb.GetAllMoviePlaylists();

            // checks if this movie already exists in this playlist
            if (currPlaylist==null)
            {
                MessageBox.Show("Изберете правилен плейлист!");
                return;
            }
            foreach (var mp in moviePlaylists)
            {
                if (movie.Id == mp.MovieId && currPlaylist.Id == mp.PlaylistId)
                {
                    string message = $"Филмът {movie.MovieTitle} вече съществува в плейлист {currPlaylist.Name}!";
                    string title = "Добави филм";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    this.Hide();
                    return;
                }
            }
            if (currPlaylist.Name=="Favourites")
            {
                movie.IsLiked = true;
            }
            MoviePlaylist newMovie = new MoviePlaylist(currPlaylist.Id, movie.Id);
            mb.Add(newMovie);
            string message2 = $"Филмът {movie.MovieTitle} e добавен в {currPlaylist.Name}!";
            string title2 = "Добави филм";
            MessageBoxButtons buttons2 = MessageBoxButtons.OK;
            DialogResult result2 = MessageBox.Show(message2, title2, buttons2);
            this.Hide();
        }
    }
}
