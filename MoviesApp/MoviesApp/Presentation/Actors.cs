using Microsoft.Data.SqlClient;
using MoviesApp.Business;
using MoviesApp.Data;
using MoviesApp.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace MoviesApp.Presentation
{
    public partial class Actors : Form
    {
        public Actors()
        {
            InitializeComponent();
        }
        MovieBusiness mb = new MovieBusiness();
        private void Actors_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            dataGridView1.DataSource = mb.GetAllActors();

            dataGridView1.Columns.RemoveAt(0);
            dataGridView1.Columns.RemoveAt(3);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //List<string> rowsInfo = new List<string>();
            //rowsInfo.Add(dataGridView1.SelectedRows.ToString());
            //textBox1.Text = rowsInfo.ToString();
            MovieBusiness mb = new MovieBusiness();
            List<MovieActor> moviesActors = new List<MovieActor>();
            moviesActors = mb.GetAllMovieActors();
            List<Movie> movies = new List<Movie>();
            movies = mb.GetAllMovies();
           
            textBox3.Text = "";
            List<string> moviesNames = new List<string>();
            List<string> outputMovies = new List<string>();
            if (e.RowIndex != -1)
            {
                DataGridViewRow dv = dataGridView1.Rows[e.RowIndex];

                // string actorId= dv.Cells[0].Value.ToString();
                List<Actor> actorsId = mb.GetAllActors().Where(a => a.FirstName == dv.Cells[0].Value.ToString() 
                && a.LastName== dv.Cells[1].Value.ToString()).ToList();
                int actorId = actorsId[0].Id;
                textBox1.Text = dv.Cells[0].Value.ToString() + " " + dv.Cells[1].Value.ToString() + "\n";
                textBox2.Text = dv.Cells[2].Value.ToString();
                foreach (var movieActor in moviesActors)
                {
                    if (movieActor.ActorId==actorId)
                    {
                        for (int i = 0; i < movies.Count; i++)
                        {
                            if (movieActor.MovieId==movies[i].Id)
                            {
                                outputMovies.Add(movies[i].MovieTitle);
                            }
                            
                        }
                        
                    }
                }
                textBox3.Text = string.Join(", ",outputMovies);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            //textBox1.ForeColor = Color.Black;
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            MovieInformation.form1.Show();
            this.Hide();
        }
    }
}
