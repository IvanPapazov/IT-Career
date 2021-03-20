using MoviesApp.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using MoviesApp.Data.Model;
using MoviesApp.Resources;
using System.IO;
using System.Diagnostics;

namespace MoviesApp.Presentation
{
    /// <summary>
    ///Клас, служещ за показване на всички филми от даден жанр 
    /// </summary>
    public partial class FormAction : Form
    {
        public List<PictureBox> filmPictureBoxes;
        /// <summary>
        /// Конструктор без параметри, служещ за инициализиране на обектите
        /// върху формата (бутони, тексови полета и др.)
        /// </summary>
        public FormAction()
        {
            InitializeComponent();
        }

        MovieBusiness mb = new MovieBusiness();
        bool canOpenPage = true;//next
        bool canReturnPage = false;//back
        int index;
        int countMoviesOnPage = 10;
        int indexImage = 1;
        int countMoviesToLoad;
        int countPages;
        int countCurrentPage = 0;
        bool isFirstPage = true;
        bool isLastPage = false;
        bool isMiddlePage = false;

        /// <summary>
        ///Метод, който извършва действието си при първоначалното зареждане на формата  
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни на събитието</param>
        private void FormAction_Load(object sender, EventArgs e)
        {
            textBox3.Text = MovieInformation.GenreName;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            filmPictureBoxes = new List<PictureBox>();
            countPages = (mb.FindMoviesFromGenre(MovieInformation.IndexGenre).Count / 10);
            if ((mb.FindMoviesFromGenre(MovieInformation.IndexGenre).Count % 10) != 0)
            {
                countPages++;
            }
            countMoviesToLoad = mb.FindMoviesFromGenre(MovieInformation.IndexGenre).Count;
            countCurrentPage++;
            if (countCurrentPage == 1)
            {
                isFirstPage = true;
            }
            if (countCurrentPage == countPages)
            {
                isLastPage = true;
            }

            //defining actions that the user can do
            if (isFirstPage == true && isLastPage == false)//first page 
            {
                pictureBox2.Visible = true;//next
                pictureBox3.Visible = false;//back
                canOpenPage = true;
                canReturnPage = false;
            }
            else if (isFirstPage == true && isLastPage == true)//only 1 page(first and last)
            {
                pictureBox2.Visible = false;//next
                pictureBox3.Visible = false;//back
                canOpenPage = true;
                canReturnPage = false;
            }
            //do the actions
            this.CenterToScreen();
            ShowImages(MovieInformation.IndexGenre, MovieInformation.GenreLetter);
        }

        /// <summary>
        /// Метод, който служи за зареждане на изображения при смяната на страниците
        /// В зависимост от входа извиква друг метод
        /// </summary>
        /// <param name="genreId">Индентификационен номер на жанр</param>
        /// <param name="genreLetter">Абревиатура, или съкращение на името на жанра</param>
        private void ShowImages(int genreId, string genreLetter)
        {
            int locationImageX = 40;
            int locationImageY = 100;
            int locationTextX = 40;
            int locationTextY = 260;

            if (canOpenPage)
            {
                ShowImagesNext(genreId, genreLetter, locationImageX, locationImageY, locationTextX, locationTextY);
            }
            if (canReturnPage)
            {
                ShowImagesBefore(genreId, genreLetter, locationImageX, locationImageY, locationTextX, locationTextY);
            }
        }

        /// <summary>
        /// Метод, служещ за зареждане на изображения на филми при отиване на следваща страница
        /// </summary>
        /// <param name="genreId">Индемтификационен номер на жанра на показваните филми</param>
        /// <param name="genreLetter">Абревиатура, или съкращение на името на жанра</param>
        /// <param name="locationImageX">Координати за начално появяване на изображение спрямо х оста</param>
        /// <param name="locationImageY">Координати за начално появяване на изображение спрямо y оста</param>
        /// <param name="locationTextX">Координати за начално появяване на текстовото поле спрямо х оста</param>
        /// <param name="locationTextY">Координати за начално появяване на текстовото поле спрямо y оста</param>
        public void ShowImagesNext(int genreId, string genreLetter, int locationImageX, int locationImageY, int locationTextX, int locationTextY)
        {
            if (countMoviesToLoad < 10)//check if the page is last, and loads <10 images on it
            {
                countMoviesOnPage = countMoviesToLoad;
            }

            for (int i = 1; i <= countMoviesOnPage; i++)
            {
                string fileName = $"fotos{genreLetter}\\{genreLetter}{indexImage}.jpg";

                PictureBox pictureBoxAction = new PictureBox();
                pictureBoxAction.Name = $"{genreLetter}{indexImage}";
                pictureBoxAction.Image = Image.FromFile(fileName);
                pictureBoxAction.Location = new Point(locationImageX, locationImageY);
                pictureBoxAction.Size = new Size(150, 150);
                pictureBoxAction.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxAction.Parent = this;
                pictureBoxAction.Visible = true;
                pictureBoxAction.BringToFront();
                locationImageX += 160;
                Movie movie = mb.FindMoviesFromGenre(genreId)[indexImage - 1];
                int indexer = indexImage;
                pictureBoxAction.Click += (s, e) =>
                {
                    MovieInformation.IndexMovie = indexer;
                    MovieInformation.LetterMovie = genreLetter;

                    MovieInformation.formAction = this;
                    var film = new Film(movie, "FormAction");
                    MovieInformation.film = film;
                    MovieInformation.film.Show();
                    this.Hide();
                };

                filmPictureBoxes.Add(pictureBoxAction);

                Label label = new Label();
                label.Name = $"{genreLetter}{indexImage}";
                label.Location = new Point(locationTextX, locationTextY);
                label.Size = new Size(150, 70);
                label.Parent = this;
                label.Visible = true;
                label.BringToFront();
                label.Text = mb.FindMoviesFromGenre(genreId)[indexImage - 1].MovieTitle;
                label.TextAlign = ContentAlignment.TopCenter;
                label.Font = new Font(label.Font, FontStyle.Italic);
                label.Font = new Font(label.Font, FontStyle.Bold);
                locationTextX += 160;

                if (locationImageX > 700)
                {
                    locationImageY += 235;
                    locationImageX = 40;
                    locationTextY = locationImageY + 175;
                    locationTextX = 40;
                }
                indexImage++;
            }
            //show images empty
            for (int i = 1; i <= 10 - countMoviesOnPage; i++)
            {
                PictureBox pictureBoxAction = new PictureBox();
                pictureBoxAction.Name = $"empty{indexImage}";
                pictureBoxAction.Location = new Point(locationImageX, locationImageY);
                pictureBoxAction.Size = new Size(150, 150);
                pictureBoxAction.Parent = this;
                pictureBoxAction.Visible = true;
                pictureBoxAction.BringToFront();
                locationImageX += 160;

                filmPictureBoxes.Add(pictureBoxAction);

                Label label = new Label();
                label.Name = $"empty{indexImage}";
                label.Location = new Point(locationTextX, locationTextY);
                label.Size = new Size(150, 70);
                label.Parent = this;
                label.Visible = true;
                label.BringToFront();
                locationTextX += 160;

                if (locationImageX > 700)
                {
                    locationImageY += 235;
                    locationImageX = 40;
                    locationTextY = locationImageY + 175;
                    locationTextX = 40;
                }
            }

            countMoviesToLoad -= countMoviesOnPage;
        }

        /// <summary>
        /// Метод, служещ за зареждане на изображения на филми при отиване на предишна страница
        /// </summary>
        /// <param name="genreId">Индемтификационен номер на жанра на показваните филми</param>
        /// <param name="genreLetter">Абревиатура, или съкращение на името на жанра</param>
        /// <param name="locationImageX">Координати за начално появяване на изображение спрямо х оста</param>
        /// <param name="locationImageY">Координати за начално появяване на изображение спрямо y оста</param>
        /// <param name="locationTextX">Координати за начално появяване на текстовото поле спрямо х оста</param>
        /// <param name="locationTextY">Координати за начално появяване на текстовото поле спрямо y оста</param>
        public void ShowImagesBefore(int genreId, string genreLetter, int locationImageX, int locationImageY, int locationTextX, int locationTextY)
        {

            index = indexImage - countMoviesOnPage;
            if (countCurrentPage + 1 == countPages)
            {
                indexImage -= countMoviesOnPage;
                countMoviesToLoad += countMoviesOnPage;
            }
            else
            {
                indexImage -= 10;
            }
            countMoviesOnPage = 0;
            for (int i = index - 10; i < index; i++)
            {
                string fileName = $"fotos{genreLetter}\\{genreLetter}{i}.jpg";
                PictureBox pictureBoxAction = new PictureBox();
                pictureBoxAction.Name = $"{genreLetter}{i}";
                pictureBoxAction.Image = Image.FromFile(fileName);
                pictureBoxAction.Location = new Point(locationImageX, locationImageY);
                pictureBoxAction.Size = new Size(150, 150);
                pictureBoxAction.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxAction.Parent = this;
                pictureBoxAction.Visible = true;
                pictureBoxAction.BringToFront();

                locationImageX += 160;


                Movie movie = mb.FindMoviesFromGenre(genreId)[i - 1];

                int indexer = i;
                pictureBoxAction.Click += (s, e) =>
                {
                    MovieInformation.IndexMovie = indexer;
                    MovieInformation.LetterMovie = genreLetter;

                    MovieInformation.formAction = this;
                    var film = new Film(movie, "FormAction");
                    MovieInformation.film = film;
                    MovieInformation.film.Show();
                    this.Hide();
                };

                filmPictureBoxes.Add(pictureBoxAction);

                Label label = new Label();
                label.Name = $"{genreLetter}{i}";
                label.Location = new Point(locationTextX, locationTextY);
                label.Size = new Size(150, 70);
                label.Parent = this;
                label.Visible = true;
                label.BringToFront();
                label.Text = mb.FindMoviesFromGenre(genreId)[i - 1].MovieTitle;
                label.TextAlign = ContentAlignment.TopCenter;
                label.Font = new Font(label.Font, FontStyle.Italic);
                label.Font = new Font(label.Font, FontStyle.Bold);
                locationTextX += 160;

                if (locationImageX > 700)
                {
                    locationImageY += 235;
                    locationImageX = 40;
                    locationTextY = locationImageY + 175;
                    locationTextX = 40;
                }
                countMoviesOnPage++;
            }
            if (countCurrentPage == 1 && countPages > 2)
            {
                countMoviesToLoad += countMoviesOnPage;
            }
        }

        /// <summary>
        /// Метод при натискане на бутон
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни на събитието</param>
        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Метод, извикващ се при навлизане на курсора на мишката
        /// в рамките на изображението
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни на събитието</param>
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox2.BringToFront();
        }

        /// <summary>
        /// Метод, извикващ се при навлизане на курсора на мишката в рамките на бутона
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(135, 206, 250);
            groupBox1.Visible = true;
            groupBox1.BringToFront();
        }

        /// <summary>
        /// Метод, извикващ се при навлизане на курсора на мишката в рамките на формата
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void FormAction_MouseEnter(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        /// <summary>
        /// Метод, извикващ се при навлизане на курсора на мишката в границите на текстовото поле
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        /// <summary>
        /// Метод, извикващ се при натискане на бутон5
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MovieInformation.form1.Show();
        }

        /// <summary>
        /// Метод, извикващ се при натискане на бутон 6
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void button6_Click(object sender, EventArgs e)//екшън
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 1;
            MovieInformation.GenreLetter = "A";
            MovieInformation.GenreName = "Екшън";
            formAction.Show();
            this.Hide();
        }

        /// <summary>
        /// Метод, извикващ се при натискане на бутон 7
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void button7_Click(object sender, EventArgs e)//приключенски
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 2;
            MovieInformation.GenreLetter = "Adv";
            MovieInformation.GenreName = "Приключенски";
            formAction.Show();
            this.Hide();
        }

        /// <summary>
        ///  Метод, извикващ се при натискане на бутон 8
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void button8_Click(object sender, EventArgs e)//комедии
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 3;
            MovieInformation.GenreLetter = "Comedy";
            MovieInformation.GenreName = "Комедии";
            formAction.Show();
            this.Hide();
        }

        /// <summary>
        /// Метод, извикващ се при натискане на бутон 9
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void button9_Click(object sender, EventArgs e)//криминални
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 4;
            MovieInformation.GenreLetter = "Criminal";
            MovieInformation.GenreName = "Криминални";
            formAction.Show();
            this.Hide();
        }

        /// <summary>
        /// Метод, извикващ се при натискане на бутон 10
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void button10_Click(object sender, EventArgs e)//фентъзи
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 5;
            MovieInformation.GenreLetter = "Fantasy";
            MovieInformation.GenreName = "Фентъзи";
            formAction.Show();
            this.Hide();
        }

        /// <summary>
        /// Метод, извикващ се при натискане на бутон 11
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void button11_Click(object sender, EventArgs e)//научна фантастика
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 6;
            MovieInformation.GenreLetter = "Sci";
            MovieInformation.GenreName = "Научна фантастика";
            formAction.Show();
            this.Hide();
        }

        /// <summary>
        /// Метод, извикващ се при натискане на бутон 12
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void button12_Click(object sender, EventArgs e)//исторически
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 7;
            MovieInformation.GenreLetter = "History";
            MovieInformation.GenreName = "Исторически";
            formAction.Show();
            this.Hide();
        }

        /// <summary>
        /// Метод, извикващ се при натискане на бутон 13
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void button13_Click(object sender, EventArgs e)//ужаси
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 8;
            MovieInformation.GenreLetter = "Horror";
            MovieInformation.GenreName = "Ужаси";
            formAction.Show();
            this.Hide();
        }

        /// <summary>
        /// Метод, извикващ се при натискане на бутон 14
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void button14_Click(object sender, EventArgs e)//романтика
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 9;
            MovieInformation.GenreLetter = "Romance";
            MovieInformation.GenreName = "Романтика";
            formAction.Show();
            this.Hide();
        }

        /// <summary>
        /// Метод, извикващ се при натискане на бутон 15
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void button15_Click(object sender, EventArgs e)//трилър
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 10;
            MovieInformation.GenreLetter = "Thriller";
            MovieInformation.GenreName = "Трилъри";
            formAction.Show();
            this.Hide();
        }

        /// <summary>
        /// Метод, извикващ се при натискане на бутон 16
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void button16_Click(object sender, EventArgs e)//анимация детско
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 11;
            MovieInformation.GenreLetter = "Cartoon";
            MovieInformation.GenreName = "Анимации";
            formAction.Show();
            this.Hide();
        }

        /// <summary>
        /// Метод, извикващ се при натискане на бутон 17
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void button17_Click(object sender, EventArgs e)//драма
        {
            var formAction = new FormAction();
            MovieInformation.IndexGenre = 12;
            MovieInformation.GenreLetter = "Drama";
            MovieInformation.GenreName = "Драма";
            formAction.Show();
            this.Hide();
        }

        /// <summary>
        /// Метод, извикващ се при натискане на бутон плейлист
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void buttonPlaylist_Click(object sender, EventArgs e)
        {
            var playlistForm = new PlaylistForm("FormAction");
            playlistForm.Show();
            MovieInformation.formAction = this;
            this.Hide();
        }

        /// <summary>
        /// Метод, извикващ се при натискане на бутон описание
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void buttonDescription_Click(object sender, EventArgs e)
        {
            var formDescription = new DescriptionForm("FormAction");
            MovieInformation.formAction = this;
            formDescription.Show();
            this.Hide();
        }

        /// <summary>
        /// Метод, извикващ се при натискане на поле за изображение 2(отиване на следваща страница)
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void pictureBox2_Click(object sender, EventArgs e)//NEXT
        {
            //defining what is the NEXT page
            countCurrentPage++;
            isFirstPage = false;
            if (countCurrentPage == countPages)//last page
            {

                isLastPage = true;
                isFirstPage = false;
                isMiddlePage = false;
            }
            if (countCurrentPage > 1 && countCurrentPage < countPages)//middle page
            {
                isMiddlePage = true;
                isFirstPage = false;
                isLastPage = false;
            }

            //defining actions that the user can do

            if (isMiddlePage == true)//middle page
            {
                pictureBox2.Visible = true;//next
                pictureBox3.Visible = true;//back
                canOpenPage = true;
                canReturnPage = false;

                ShowImages(MovieInformation.IndexGenre, MovieInformation.GenreLetter);

            }
            else if (isLastPage == true && isFirstPage == false)//last page
            {
                pictureBox2.Visible = false;//next
                pictureBox3.Visible = true;//back
                //MessageBox.Show("can go next");
                canOpenPage = true;
                canReturnPage = false;

                ShowImages(MovieInformation.IndexGenre, MovieInformation.GenreLetter);
            }
            //MessageBox.Show(indexImage.ToString());
            //do the actions

        }

        /// <summary>
        /// Метод, извикващ се при натискане на поле за изображение 3(отиване на предходна страница)
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void pictureBox3_Click(object sender, EventArgs e)//BACK
        {
            //defining which is the PREVIOUS page
            countCurrentPage--;
            isLastPage = false;
            if (countCurrentPage == 1)//first page
            {
                isFirstPage = true;
            }
            if (countCurrentPage > 1 && countCurrentPage < countPages)//middle page
            {
                isMiddlePage = true;
            }

            //defining actions that the user can do
            if (isFirstPage == true && isLastPage == false)//first page 
            {
                pictureBox2.Visible = true;//next
                pictureBox3.Visible = false;//back
                canOpenPage = false;
                canReturnPage = true;
                //MessageBox.Show("You can go back");
                ShowImages(MovieInformation.IndexGenre, MovieInformation.GenreLetter);


            }
            else if (isMiddlePage == true)//middle page
            {
                pictureBox2.Visible = true;//next
                pictureBox3.Visible = true;//back
                canOpenPage = false;
                canReturnPage = true;
                ShowImages(MovieInformation.IndexGenre, MovieInformation.GenreLetter);
            }
        }

        /// <summary>
        /// Метод, извикващ се при натискане на бутон добави филм
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            var addMovieForm = new AddMovieForm("FormAction");
            MovieInformation.formAction = this;
            addMovieForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Метод, извикващ се при натискане на бутон 2
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void button2_Click(object sender, EventArgs e)
        {
            MovieInformation.formAction = this;
            var formActors = new Actors("FormAction");
            MovieInformation.actors = formActors;
            MovieInformation.actors.Show();
            this.Hide();
        }

        /// <summary>
        /// Метод, викащ се при навлизане на курсора на мишката в границите на бутон 2
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(135, 206, 250);
        }

        /// <summary>
        /// Метод, викащ се при навлизане на курсора на мишката в границите на бутон 5
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(135, 206, 250);
        }

        /// <summary>
        /// Метод, викащ се при излизане на курсора на мишката от границите на бутон 5
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(240, 255, 255);
        }

        /// <summary>
        /// Метод, викащ се при излизане на курсора на мишката от границите на бутон 2
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(240, 255, 255);
        }

        /// <summary>
        /// Метод, викащ се при излизане на курсора на мишката от границите на бутон 1
        /// </summary>
        /// <param name="sender">Обект, изпращащ събитието</param>
        /// <param name="e">Данни за събитието</param>
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(240, 255, 255);
        }
    }
}

