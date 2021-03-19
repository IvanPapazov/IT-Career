﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using MoviesApp.Business;
using System.Diagnostics;

namespace MoviesApp.Presentation
{
    public partial class AddMovieForm : Form
    {
        public AddMovieForm(string forms)
        {
            InitializeComponent();
            previousFormType = forms;
        }
        private void textBoxDirectorFirstName_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBoxDirectorFirstName.ForeColor == Color.Silver || textBoxDirectorFirstName.ForeColor == Color.Red)
            {
                textBoxDirectorFirstName.Text = "";
                textBoxDirectorFirstName.Font = new Font(textBoxDirectorFirstName.Font.FontFamily, 15);
                textBoxDirectorFirstName.Font = new Font(textBoxDirectorFirstName.Font, FontStyle.Bold);
                textBoxDirectorFirstName.ForeColor = Color.Black;
            }
        }
        private void textBoxDirectorFirstName_Leave(object sender, EventArgs e)
        {
            if (textBoxDirectorFirstName.Text == "")
            {
                textBoxDirectorFirstName.ForeColor = Color.Silver;
                textBoxDirectorFirstName.Text = "Име";
            }
        }
        private void textBoxDirectorLastName_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBoxDirectorLastName.ForeColor == Color.Silver || textBoxDirectorLastName.ForeColor == Color.Red)
            {
                textBoxDirectorLastName.Text = "";
                textBoxDirectorLastName.Font = new Font(textBoxDirectorLastName.Font.FontFamily, 15);
                textBoxDirectorLastName.Font = new Font(textBoxDirectorLastName.Font, FontStyle.Bold);
                textBoxDirectorLastName.ForeColor = Color.Black;
            }
        }
        private void textBoxDirectorLastName_Leave(object sender, EventArgs e)
        {
            if (textBoxDirectorLastName.Text == "")
            {
                textBoxDirectorLastName.ForeColor = Color.Silver;
                textBoxDirectorLastName.Text = "Фамилия";
            }
        }
        private void textBoxActorMan_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBoxActorMan.ForeColor == Color.Silver || textBoxActorMan.ForeColor == Color.Red)
            {
                textBoxActorMan.Text = "";
                textBoxActorMan.ForeColor = Color.Black;
            }
        }
        private void textBoxActorMan_Leave(object sender, EventArgs e)
        {
            if (textBoxActorMan.Text == "")
            {
                textBoxActorMan.ForeColor = Color.Silver;
                textBoxActorMan.Text = "Мъже";
            }
        }
        private void textBoxActorWoman_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBoxActorWoman.ForeColor == Color.Silver || textBoxActorWoman.ForeColor == Color.Red)
            {
                textBoxActorWoman.Text = "";
                textBoxActorWoman.ForeColor = Color.Black;
            }
        }
        private void textBoxActorWoman_Leave(object sender, EventArgs e)
        {
            if (textBoxActorWoman.Text == "")
            {
                textBoxActorWoman.ForeColor = Color.Silver;
                textBoxActorWoman.Text = "Жени";
            }
        }
        private void textBoxMovieName_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBoxMovieName.ForeColor == Color.Silver || textBoxMovieName.ForeColor == Color.Red)
            {
                textBoxMovieName.Text = "";
                textBoxMovieName.Font = new Font(textBoxMovieName.Font.FontFamily, 15);
                textBoxMovieName.Font = new Font(textBoxMovieName.Font, FontStyle.Bold);
                textBoxMovieName.ForeColor = Color.Black;
            }
        }
        private void textBoxMovieName_Leave(object sender, EventArgs e)
        {
            if (textBoxMovieName.Text == "")
            {
                textBoxMovieName.ForeColor = Color.Silver;
                textBoxMovieName.Text = "Име";
            }
        }
        private void textBoxMovieCountry_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBoxMovieCountry.ForeColor == Color.Silver || textBoxMovieCountry.ForeColor == Color.Red)
            {
                textBoxMovieCountry.Text = "";
                textBoxMovieCountry.Font = new Font(textBoxMovieCountry.Font.FontFamily, 15);
                textBoxMovieCountry.Font = new Font(textBoxMovieCountry.Font, FontStyle.Bold);
                textBoxMovieCountry.ForeColor = Color.Black;
            }
        }
        private void textBoxMovieCountry_Leave(object sender, EventArgs e)
        {
            if (textBoxMovieCountry.Text == "")
            {
                textBoxMovieCountry.ForeColor = Color.Silver;
                textBoxMovieCountry.Text = "Държава";
            }
        }
        private void textBoxMovieDuration_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBoxMovieDuration.ForeColor == Color.Silver || textBoxMovieDuration.ForeColor == Color.Red)
            {
                textBoxMovieDuration.Text = "";
                textBoxMovieDuration.Font = new Font(textBoxMovieDuration.Font.FontFamily, 14);
                textBoxMovieDuration.Font = new Font(textBoxMovieDuration.Font, FontStyle.Bold);
                textBoxMovieDuration.ForeColor = Color.Black;
            }
        }
        private void textBoxMovieYear_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (textBoxMovieYear.ForeColor == Color.Silver || textBoxMovieYear.ForeColor == Color.Red)
            {
                textBoxMovieYear.Text = "";
                textBoxMovieYear.Font = new Font(textBoxMovieYear.Font.FontFamily, 15);
                textBoxMovieYear.Font = new Font(textBoxMovieYear.Font, FontStyle.Bold);
                textBoxMovieYear.ForeColor = Color.Black;
            }
        }
        private void textBoxMovieYear_Leave(object sender, EventArgs e)
        {
            if (textBoxMovieYear.Text == "")
            {
                textBoxMovieYear.ForeColor = Color.Silver;
                textBoxMovieYear.Text = "Година";
            }
        }
        private void textBoxMovieDiscription_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBoxMovieDiscription.ForeColor == Color.Silver || textBoxMovieDiscription.ForeColor == Color.Red)
            {
                textBoxMovieDiscription.Text = "";
                textBoxMovieDiscription.ForeColor = Color.Black;
            }
        }
        private void textBoxMovieDiscription_Leave(object sender, EventArgs e)
        {
            if (textBoxMovieDiscription.Text == "")
            {
                textBoxMovieDiscription.ForeColor = Color.Silver;
                textBoxMovieDiscription.Text = "Описание";
            }
        }
        private void textBoxMovieDuration_Leave_1(object sender, EventArgs e)
        {
            if (textBoxMovieDuration.Text == "")
            {
                textBoxMovieDuration.ForeColor = Color.Silver;
                textBoxMovieDuration.Text = "Времетраене";
            }
        }
        private void AddMovieForm_Load(object sender, EventArgs e)
        {
            pictureBoxDragDrob.AllowDrop = true;
        }
        string previousFormType;
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (this.previousFormType == "Form1")
            {
                MovieInformation.form1.Show();
            }
            else
            {
                MovieInformation.formAction.Show();
            }
        }
        bool isFind = true;
        object data;
        MovieBusiness mb = new MovieBusiness();
        private void pictureBoxApply_Click(object sender, EventArgs e)
        {
            if (textBoxActorMan.ForeColor == Color.Silver || textBoxActorMan.ForeColor == Color.Red)
            {
                isFind = false;
                textBoxActorMan.ForeColor = Color.Red;
                textBoxActorMan.Text = "Това поле е задължително!";
            }
            else
            {
                isFind = true;
            }
            if (textBoxActorWoman.ForeColor == Color.Silver || textBoxActorWoman.ForeColor == Color.Red)
            {
                isFind = false;
                textBoxActorWoman.ForeColor = Color.Red;
                textBoxActorWoman.Text = "Това поле е задължително!";
            }
            else
            {
                isFind = true;
            }
            if (textBoxDirectorFirstName.ForeColor == Color.Silver || textBoxDirectorFirstName.ForeColor == Color.Red)
            {
                isFind = false;
                textBoxDirectorFirstName.ForeColor = Color.Red;
                textBoxDirectorFirstName.Font = new Font(textBoxDirectorFirstName.Font.FontFamily, 9);
                textBoxDirectorFirstName.Font = new Font(textBoxDirectorFirstName.Font, FontStyle.Bold);
                textBoxDirectorFirstName.Text = "Това поле е задължително!";
            }
            else
            {
                isFind = true;
            }
            if (textBoxDirectorLastName.ForeColor == Color.Silver || textBoxDirectorLastName.ForeColor == Color.Red)
            {
                isFind = false;
                textBoxDirectorLastName.ForeColor = Color.Red;
                textBoxDirectorLastName.Font = new Font(textBoxDirectorLastName.Font.FontFamily, 9);
                textBoxDirectorLastName.Font = new Font(textBoxDirectorLastName.Font, FontStyle.Bold);
                textBoxDirectorLastName.Text = "Това поле е задължително!";
            }
            else
            {
                isFind = true;
            }
            if (textBoxMovieCountry.ForeColor == Color.Silver || textBoxMovieCountry.ForeColor == Color.Red)
            {
                isFind = false;
                textBoxMovieCountry.ForeColor = Color.Red;
                textBoxMovieCountry.Font = new Font(textBoxMovieCountry.Font.FontFamily, 9);
                textBoxMovieCountry.Font = new Font(textBoxMovieCountry.Font, FontStyle.Bold);
                textBoxMovieCountry.Text = "Това поле е задължително!";
            }
            else
            {
                isFind = true;
            }
            if (textBoxMovieDiscription.ForeColor == Color.Silver || textBoxMovieDiscription.ForeColor == Color.Red)
            {
                isFind = false;
                textBoxMovieDiscription.ForeColor = Color.Red;
                textBoxMovieDiscription.Text = "Това поле е задължително!";
            }
            else
            {
                isFind = true;
            }
            if (textBoxMovieDuration.ForeColor == Color.Silver || textBoxMovieDuration.ForeColor == Color.Red)
            {
                isFind = false;
                textBoxMovieDuration.ForeColor = Color.Red;
                textBoxMovieDuration.Font = new Font(textBoxMovieDuration.Font.FontFamily, 9);
                textBoxMovieDuration.Font = new Font(textBoxMovieDuration.Font, FontStyle.Bold);
                textBoxMovieDuration.Text = "Това поле е задължително!";
            }
            else
            {
                isFind = true;
            }
            if (textBoxMovieName.ForeColor == Color.Silver || textBoxMovieName.ForeColor == Color.Red)
            {
                isFind = false;
                textBoxMovieName.ForeColor = Color.Red;
                textBoxMovieName.Font = new Font(textBoxMovieName.Font.FontFamily, 9);
                textBoxMovieName.Font = new Font(textBoxMovieName.Font, FontStyle.Bold);
                textBoxMovieName.Text = "Това поле е задължително!";
            }
            else
            {
                isFind = true;
            }
            if (textBoxMovieYear.ForeColor == Color.Silver || textBoxMovieYear.ForeColor == Color.Red)
            {
                isFind = false;
                textBoxMovieYear.ForeColor = Color.Red;
                textBoxMovieYear.Font = new Font(textBoxMovieYear.Font.FontFamily, 9);
                textBoxMovieYear.Font = new Font(textBoxMovieYear.Font, FontStyle.Bold);
                textBoxMovieYear.Text = "Това поле е задължително!";
            }
            else
            {
                isFind = true;
            }
            if (checkedListBoxMovieGenre.ForeColor == Color.Silver || checkedListBoxMovieGenre.ForeColor == Color.Red)
            {
                checkedListBoxMovieGenre.ForeColor = Color.Red;
                isFind = false;
            }
            else
            {
                isFind = true;
            }

            if (isFind)
            {
                string message = $"Сигурни ли сте че искате да добавите този филм?";
                string title = "";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    string[] directorName = { textBoxDirectorFirstName.Text, textBoxDirectorLastName.Text };
                    List<string> actors = new List<string>();
                    List<string> actorsMan = textBoxActorMan.Text.Split(", ").ToList();
                    List<string> actorsWoman = textBoxActorWoman.Text.Split(", ").ToList();
                    foreach (var item in actorsMan)
                    {
                        string actor = item + " мъж";
                        actors.Add(actor);
                    }
                    foreach (var item in actorsWoman)
                    {
                        string actor = item + " жена";
                        actors.Add(actor);
                    }
                    List<string> genres = new List<string>();
                    foreach (var item in checkedListBoxMovieGenre.CheckedItems)
                    {
                        genres.Add(item.ToString());

                    }
                    string movieName = textBoxMovieName.Text;
                    int movieYear = int.Parse(textBoxMovieYear.Text);
                    int movieDuration = int.Parse(textBoxMovieDuration.Text);
                    string movieCountry = textBoxMovieCountry.Text;
                    string movieDisctiption = textBoxMovieDiscription.Text;
                    mb.AddMovieInDatabase(directorName, actors, genres, movieName, movieYear, movieDuration, movieCountry, movieDisctiption, data);

                    data = null;
                    textBoxMovieName.ForeColor = Color.Silver;
                    textBoxMovieName.Text = "Име";
                    textBoxMovieYear.ForeColor = Color.Silver;
                    textBoxMovieYear.Text = "Година";
                    textBoxMovieDuration.ForeColor = Color.Silver;
                    textBoxMovieDuration.Text = "Времетраене";
                    textBoxMovieCountry.ForeColor = Color.Silver;
                    textBoxMovieCountry.Text = "Държава";
                    textBoxMovieDiscription.ForeColor = Color.Silver;
                    textBoxMovieDiscription.Text = "Описание";
                    textBoxDirectorFirstName.ForeColor = Color.Silver;
                    textBoxDirectorFirstName.Text = "Име";
                    textBoxDirectorLastName.ForeColor = Color.Silver;
                    textBoxDirectorLastName.Text = "Фамилия";
                    textBoxActorMan.ForeColor = Color.Silver;
                    textBoxActorMan.Text = "Мъже";
                    textBoxActorWoman.ForeColor = Color.Silver;
                    textBoxActorWoman.Text = "Жени";
                    checkedListBoxMovieGenre.ForeColor = Color.Silver;
                    for (int i = 0; i < checkedListBoxMovieGenre.CheckedIndices.Count; i++)
                    {
                        checkedListBoxMovieGenre.SetItemChecked(checkedListBoxMovieGenre.CheckedIndices[i], false);
                    }
                }
            }
        }
        private void checkedListBoxMovieGenre_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            checkedListBoxMovieGenre.ForeColor = Color.Black;
        }
        private void checkedListBoxMovieGenre_Leave(object sender, EventArgs e)
        {
            if (checkedListBoxMovieGenre.CheckedItems.Count == 0)
            {
                checkedListBoxMovieGenre.ForeColor = Color.Silver;
            }
        }
        private void pictureBoxDragDrob_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void pictureBoxDragDrob_DragDrop(object sender, DragEventArgs e)
        {
            data = e.Data.GetData(DataFormats.FileDrop);
        }
        private void pictureBoxDragDrob_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "C:\\",
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}
