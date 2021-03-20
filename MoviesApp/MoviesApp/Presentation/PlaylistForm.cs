using MoviesApp.Business;
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
    public partial class PlaylistForm : Form
    {

        string previousFormType = "";

        /// <summary>
        /// Конструктор на формата за добавяне на плейлисти.
        /// </summary>
        /// <param name="previousFormType">Име на формата, от която се отваря текущата</param>
        public PlaylistForm(string previousFormType)
        {
            InitializeComponent();
            this.previousFormType = previousFormType;
        }
        MovieBusiness mb = new MovieBusiness();
        private int editId = 0;

        List<Movie> currMovies = new List<Movie>();
        Playlist currPlaylist;
        List<MoviePlaylist> moviePlaylists = new List<MoviePlaylist>();
        List<Movie> movies = new List<Movie>();

        /// <summary>
        /// Метод, който се извиква при първоначално зареждане на формата.
        /// </summary>
        /// <param name="sender">Обект изпращащ събитието</param>
        /// <param name="e">Данни на събитието</param>
        private void PlaylistForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            UpdateGrid();
            ClearTextBoxes();
            textBoxName.Enabled = false;
            textBoxFilm.Enabled = false;
            buttonDeleteMovie.Enabled = false;

        }

        /// <summary>
        /// Метод, който презарежда таблицата (dataGridViewPlaylist контролата), като взима информацията 
        /// от таблицата в базата, която съдържа плейлистите в приложението.
        /// </summary>
        private void UpdateGrid()
        {
            dataGridViewPlaylist.DataSource = mb.GetAllPlaylists();

            dataGridViewPlaylist.Columns.RemoveAt(0);
            dataGridViewPlaylist.Columns.RemoveAt(1);
            dataGridViewPlaylist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Метод, който презарежда таблицата (dataGridViewFilms контролата) с филми от избран плейлист. 
        /// </summary>
        private void UpdateGrid2()
        {
            labelFilms.Visible = true;
            dataGridViewFilms.Visible = true;
            dataGridViewFilms.DataSource = currMovies;

            if (dataGridViewFilms.Columns.Count > 1)
            {
                dataGridViewFilms.Columns.RemoveAt(0);
                for (int i = 0; i < 10; i++)
                {
                    dataGridViewFilms.Columns.RemoveAt(1);
                }
            }

            dataGridViewFilms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Метод, който прави бутоните и текстовото поле по-долу невидими и недостъпни. 
        /// </summary>
        private void ClearTextBoxes()
        {
            textBoxAdd.Visible = false;
            textBoxAdd.Enabled = false;

            buttonSave.Enabled = false;
            buttonSave.Visible = false;

            buttonSave2.Enabled = false;
            buttonSave2.Visible = false;
        }

        /// <summary>
        /// Метод, зареждащ се при натискане на клетка от контролата dataGridViewPlaylist
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void dataGridViewPlaylist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxFilm.Text = "";
            textBoxFilm.Visible = false;           

            textBoxName.Text = "";

            if (e.RowIndex != -1)
            {
                DataGridViewRow dv = dataGridViewPlaylist.Rows[e.RowIndex];
                string playListName = dv.Cells[0].Value.ToString();
                textBoxName.Text = playListName; //!

                currPlaylist = mb.GetAllPlaylists().Where(p => p.Name == playListName).ToList().FirstOrDefault();
                int playListId = currPlaylist.Id;

                // extracts the movies in the current playlist
                FullCurrentMovies();
                UpdateGrid2();
            }
        }

        /// <summary>
        /// Метод, който активира метод за запазване на новодобавен плейлист.
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxAdd.Text = "";
            textBoxAdd.Visible = true;
            textBoxAdd.Enabled = true;
            buttonSave.Visible = true;
            buttonSave.Enabled = true;

            buttonAdd.Visible = false;
            buttonAdd.Enabled = false;
        }

        /// <summary>
        /// Метод за запазване на новодобавен плейлист в базата.
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string playListName = textBoxAdd.Text;
            if (playListName == "")
            {
                string message = $"Първо въведте име на плейлист!";
                string title = "Добави плейлист";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                textBoxAdd.Focus();
                return;
            }
            List<Playlist> playlists = mb.GetAllPlaylists();
            foreach (var p in playlists)
            {
                if (playListName == p.Name)
                {
                    string message = $"Такъв плейлист вече съществува!";
                    string title = "Добави плейлист";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    textBoxAdd.Text = "";
                    textBoxAdd.Focus();
                    return;
                }
            }

            Playlist currplaylist = new Playlist(playListName);
            mb.Add(currplaylist);
            UpdateGrid();
            ClearTextBoxes();
            buttonAdd.Visible = true;
            buttonAdd.Enabled = true;
        }

        /// <summary>
        /// Метод, който дава възможност за преименуване на даден плейлист и активира метод за запазване на промените.
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void buttonRename_Click(object sender, EventArgs e)
        {
            if (dataGridViewPlaylist.SelectedRows.Count > 0)
            {
                var item = dataGridViewPlaylist.SelectedRows[0].Cells;
                List<Playlist> playLists = mb.GetAllPlaylists().Where(p => p.Name == item[0].Value.ToString()).ToList();
                int id = playLists[0].Id;
                editId = id;
                
                Playlist oldPlayList = mb.GetPlaylist(id);
                textBoxName.Enabled = true;
                textBoxName.Visible = true;
                textBoxName.Text = oldPlayList.Name;
                textBoxName.Focus();
                ToggleSaveUpdate();
                dataGridViewPlaylist.Enabled = false;
            }
        }

        /// <summary>
        /// Метод, който сменя видимостта на бутоните, отговарящи за преименуването на плейлист и запазването на промените.
        /// </summary>
        private void ToggleSaveUpdate()
        {
            if (buttonRename.Visible)
            {
                buttonSave2.Visible = true;
                buttonSave2.Enabled = true;
                buttonRename.Visible = false;
                buttonRename.Enabled = false;
            }
            else
            {
                buttonSave2.Visible = false;
                buttonSave2.Enabled = false;
                buttonRename.Visible = true;
                buttonRename.Enabled = true;
            }

        }
        /// <summary>
        /// Метод за запазване на промените при преименуване на плейлист.
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void buttonSave2_Click(object sender, EventArgs e)
        {
            string newName = textBoxName.Text;
            Playlist newPlaylist = new Playlist(newName);
            newPlaylist.Id = editId;

            mb.UpdatePlaylistName(newPlaylist, newName);
            UpdateGrid();

            // ResetSelect
            dataGridViewPlaylist.ClearSelection();
            dataGridViewPlaylist.Enabled = true;
            ToggleSaveUpdate();
            textBoxName.Enabled = false;
        }

        /// <summary>
        /// Метод, позволяващ изтриване на плейлист от базата.
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void buttonDelete_Click(object sender, EventArgs e) // DeletePlaylist
        {
            if (dataGridViewPlaylist.SelectedRows.Count > 0)
            {
                var item = dataGridViewPlaylist.SelectedRows[0].Cells;
                List<Playlist> playLists = mb.GetAllPlaylists().Where(p => p.Name == item[0].Value.ToString()).ToList();
                int id = playLists[0].Id;
                editId = id;
                string name = playLists[0].Name;
              
                textBoxName.Visible = true;
                textBoxName.Text = name;
                dataGridViewPlaylist.Enabled = false;

                ShowMessageBox(name);

            }
        }

        /// <summary>
        /// Метод, който визуализира съобщение при опит за изтриване на плейлист.
        /// </summary>
        /// <param name="name">Име на плейлист</param>
        private void ShowMessageBox(string name)
        {
            string message = $"Сигурни ли сте, че искате да изтриете плейлист \"{name}\"";
            string title = "Изтрий плейлист";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                mb.DeletePlaylist(editId);
                UpdateGrid();           
            }
            dataGridViewPlaylist.ClearSelection();
            dataGridViewPlaylist.Enabled = true;
        }

        /// <summary>
        /// Метод, зареждащ се при натискане на клетка от контролата dataGridViewFilms
        /// </summary>
        /// <param name="sender">Обект, зареждащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void dataGridViewFilms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dvFilms = dataGridViewFilms.Rows[e.RowIndex];
                string filmName = dvFilms.Cells[0].Value.ToString();
                textBoxFilm.Visible = true;
                textBoxFilm.Text = filmName;

                buttonDeleteMovie.Enabled = true;
                buttonDeleteMovie.Visible = true;
            }
        }

        /// <summary>
        /// Метод, поволяващ изтриването на филм от избран плейлист.
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни на събитието</param>
        private void buttonDeleteMovie_Click(object sender, EventArgs e)
        {
            if (dataGridViewFilms.SelectedRows.Count > 0)
            {
                var item = dataGridViewFilms.SelectedRows[0].Cells;
                Movie movie = mb.GetAllMovies().Where(m => m.MovieTitle == item[0].Value.ToString()).ToList().FirstOrDefault();
                int movieId = movie.Id;
                string movieName = movie.MovieTitle;

                dataGridViewFilms.Enabled = false;
                ShowMessageBoxForFilm(movieName, movieId);
            }
        }

        /// <summary>
        /// Метод, визуализиращ съобщение при опит да се изтрие филм от плейлист
        /// </summary>
        /// <param name="movieName">име на филма</param>
        /// <param name="movieId">номер на филма</param>
        private void ShowMessageBoxForFilm(string movieName, int movieId)
        {
            string playListName = currPlaylist.Name;
            string message = $"Сигурни ли сте, че искате да изтриете филма \"{movieName}\" от плейлист \"{playListName}\"";
            string title = "Изтрий филм от плейлист";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                mb.DeleteMovieFromPlaylist(currPlaylist.Id, movieId);
                FullCurrentMovies();
                
            }
            dataGridViewFilms.Visible = false;
            UpdateGrid2();
            dataGridViewFilms.Visible = true;

            dataGridViewFilms.ClearSelection();
            dataGridViewFilms.Enabled = true;

            buttonDeleteMovie.Enabled = false;
            buttonDeleteMovie.Visible = false;
        }

        /// <summary>
        /// Метод, който намира и запазва в колекция от "Филми" филмите, които се намират в избран плейлист
        /// </summary>
        private void FullCurrentMovies()
        {
            moviePlaylists = mb.GetAllMoviePlaylists();
            movies = mb.GetAllMovies();
            currMovies = new List<Movie>();
            foreach (var mp in moviePlaylists)
            {
                if (mp.PlaylistId == currPlaylist.Id)
                {
                    foreach (var m in movies)
                    {
                        if (m.Id == mp.MovieId)
                        {
                            currMovies.Add(m);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Метод, който се зарежда при натискане на изображението "стрелка назад", който ни връща към предишната форма
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни на събитието</param>
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

        /// <summary>
        /// Метод, зареждащ се при вкарване на курсора на мишката върху бутона за добавяне на плейлист
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни на събитието</param>
        private void buttonAdd_MouseEnter(object sender, EventArgs e)
        {
            buttonAdd.BackColor = Color.Gray;
        }

        /// <summary>
        /// Метод, зареждащ се при премахване на курсора на мишката от бутона за добавяне на плейлист
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни на събитието</param>
        private void buttonAdd_MouseLeave(object sender, EventArgs e)
        {
            buttonAdd.BackColor = Color.Silver;
        }

        /// <summary>
        /// Метод, зареждащ се при вкарване на курсора на мишката върху бутона за запзване на новодобавен плейлист
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни на събитието</param>
        private void buttonSave_MouseEnter(object sender, EventArgs e)
        {
            buttonSave.BackColor = Color.Gray;
        }

        /// <summary>
        /// Метод, зареждащ се при напускане на курсора на мишката от бутона за запзване на новодобавен плейлист
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни на събитието</param>
        private void buttonSave_MouseLeave(object sender, EventArgs e)
        {
            buttonSave.BackColor = Color.Silver;
        }

        /// <summary>
        /// Метод, зареждащ се при вкарване на курсора на мишката върху бутона за преименуване на плейлист
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни на събитието</param>
        private void buttonRename_MouseEnter(object sender, EventArgs e)
        {
            buttonRename.BackColor = Color.Gray;
        }

        /// <summary>
        /// Метод, зареждащ се при напускане на курсора на мишката от бутона за преименуване на плейлист
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни на събитието</param>
        private void buttonRename_MouseLeave(object sender, EventArgs e)
        {
            buttonRename.BackColor = Color.Silver;
        }

        /// <summary>
        /// Метод, зареждащ се при вкарване на курсора на мишката върху бутона за запазване на промяната на името
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни на събитието</param>
        private void buttonSave2_MouseEnter(object sender, EventArgs e)
        {
            buttonSave2.BackColor = Color.Gray;
        }

        /// <summary>
        /// Метод, зареждащ се при напускане на курсора на мишката от бутона за запазване на промяната на името
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни на събитието</param>
        private void buttonSave2_MouseLeave(object sender, EventArgs e)
        {
            buttonSave2.BackColor = Color.Silver;
        }

        /// <summary>
        /// Метод, зареждащ се при вкарване на курсора на мишката върху бутона за изтриване на плейлист
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни на събитието</param>
        private void buttonDelete_MouseEnter(object sender, EventArgs e)
        {
            buttonDelete.BackColor = Color.Gray;
        }

        /// <summary>
        /// Метод, зареждащ се при напускане на курсора на мишката от бутона за изтриване на плейлист
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни на събитието</param>
        private void buttonDelete_MouseLeave(object sender, EventArgs e)
        {
            buttonDelete.BackColor = Color.Silver;
        }

        /// <summary>
        /// Метод, зареждащ се при вкарване на курсора на мишката върху бутона за изтриване на филм от плейлист
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни на събитието</param>
        private void buttonDeleteMovie_MouseEnter(object sender, EventArgs e)
        {
            buttonDeleteMovie.BackColor = Color.Gray;
        }

        /// <summary>
        /// Метод, зареждащ се при напускане на курсора на мишката от бутона за изтриване на филм от плейлист
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни на събитието</param>
        private void buttonDeleteMovie_MouseLeave(object sender, EventArgs e)
        {
            buttonDeleteMovie.BackColor = Color.Silver;
        }
    }
}
