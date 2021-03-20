using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MoviesApp.Presentation
{
    /// <summary>
    /// Това е класът на формата за описанието на приложението
    /// </summary>
    public partial class DescriptionForm : Form
    {
        string previousFormType = "";
        /// <summary>
        /// Това е конструкторът на класа за описанието
        /// </summary>
        /// <param name="previousFormType">Името на предходната форма</param>
        public DescriptionForm(string previousFormType)
        {
            InitializeComponent();
            this.previousFormType = previousFormType;
        }
        /// <summary>
        ///  Метод който се стартира при пускането на формата
        /// </summary>
        /// <param name="sender">Обект изпращащ събитието</param>
        /// <param name="e">Данни на събитието</param>
        private void DescriptionForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            textBoxForm1first.ForeColor = Color.Black;
            textBoxForm1first.Font = new Font(textBoxForm1first.Font, FontStyle.Bold);
            textBoxForm1first.Enabled = false;
            textBoxForm1first.Text = "=> Това е стартовата форма на пректа." +
                Environment.NewLine + 
                 "=> От нея може да се достъпват филмите според техния жанр, актьорите и плейлистите." +
                 Environment.NewLine +
                "=> В менюто \"хамбургер\" се намира бутон, който отвежда към функционалност за добавяне на нов филм."+
                Environment.NewLine + 
                "=> \"Чрез търсачката\" директно може да намерите филм." +
                Environment.NewLine +
                "=> Чрез бутона \"Изход\" се спира приложението.";

            textBoxFAction.ForeColor = Color.Black;
            textBoxFAction.Font = new Font(textBoxForm1first.Font, FontStyle.Bold);
            textBoxFAction.Enabled = false;

            textBoxFAction.Text = "=> На тази форма се визуализират филмите от един жанр." +
                Environment.NewLine + 
                "=> При натискане върху дадена снимка се появява повече информация за избрания филм.";

            textBoxFilm.ForeColor = Color.Black;
            textBoxFilm.Font = new Font(textBoxForm1first.Font, FontStyle.Bold);
            textBoxFilm.Enabled = false;
            textBoxFilm.Text = "=> Тази форма визуализира информация за избрания филм." +
            Environment.NewLine +
                "=> При натискане на сърчицето филмът се харесва и се добавя към плейлист \"Favourites\"."
                + Environment.NewLine +
                "=> При повторно натискане на сърчицето филмът се отхаресва и се премахва от \"Favourites\"."
                +Environment.NewLine +
                "=> При натискане на плюса филмът може да се добави в плейлист.";

            textBoxPlaylist.ForeColor = Color.Black;
            textBoxPlaylist.Font = new Font(textBoxForm1first.Font, FontStyle.Bold);
            textBoxPlaylist.Enabled = false;

            textBoxPlaylist.Text = "=> Тази форма визуализира информация за всички плейлисти и филмите в избран пейлист."+
                Environment.NewLine +
                "=> С бутоните може да добавите, промените и изтриете плейлист, както и да изтриете филм от плейлист.";

            textBoxAddFilm.ForeColor = Color.Black;
            textBoxAddFilm.Font = new Font(textBoxForm1first.Font, FontStyle.Bold);
            textBoxAddFilm.Enabled = false;

            textBoxAddFilm.Text = "=> Чрез тази форма се добавя нов филм в приложението."+
                Environment.NewLine +
                "=> За да се добави филм трябва задължително да се въведат полетата и да се натисне иконата в " +
                "долния десен ъгъл."+
                Environment.NewLine + 
                "=> Ако желаете може да добавите снимка като я влачите и пуснете върху обособеното иображение.";
        }
        /// <summary>
        /// Метод при който при натискане върху снимката се изпълнява дадения код
        /// </summary>
        /// <param name="sender">Обект изпращащ събитието</param>
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
