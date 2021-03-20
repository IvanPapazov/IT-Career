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
    /// <summary>
    /// Това е класът на формата за актьорите
    /// </summary>
    public partial class Actors : Form
    {
        string previousPage;
        /// <summary>
        /// Консртуктор на формата
        /// </summary>
        /// <param name="previousPage">Име на предишната форма</param>
        public Actors(string previousPage)
        {
            InitializeComponent();
            this.previousPage = previousPage;
        }
        MovieBusiness mb = new MovieBusiness();
        /// <summary>
        ///  Метод който се стартира при пускането на формата
        /// </summary>
        /// <param name="sender">Обект изпращащ събитието</param>
        /// <param name="e">Данни на събитието</param>
        private void Actors_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            UpdateGrid();
        }
        /// <summary>
        /// Ъпдейтва визуализацията на грида
        /// </summary>
        private void UpdateGrid()
        {
            dataGridView1.DataSource = mb.GetAllActors();

            dataGridView1.Columns.RemoveAt(0);
            dataGridView1.Columns.RemoveAt(3);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        /// <summary>
        /// Метод който извършва действие при натискане върху определена клетка от грида
        /// </summary>
        /// <param name="sender">Обект изпращащ събитието</param>
        /// <param name="e">Данни на събитието</param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
        /// <summary>
        /// Метод при който при натискане връща предишната форма
        /// </summary>
        /// <param name="sender">Обект изпращащ събитието</param>
        /// <param name="e">Данни на събитието</param>
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            if (previousPage=="Form1")
            {
                MovieInformation.form1.Show();
            }
            else if (previousPage=="FormAction")
            {
                MovieInformation.formAction.Show();
            }
            this.Hide();
        }
    }
}
