
namespace MoviesApp.Presentation
{
    partial class AddMovieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMovieForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDirectorLastName = new System.Windows.Forms.TextBox();
            this.textBoxDirectorFirstName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxActorWoman = new System.Windows.Forms.TextBox();
            this.textBoxActorMan = new System.Windows.Forms.TextBox();
            this.Филм = new System.Windows.Forms.GroupBox();
            this.checkedListBoxMovieGenre = new System.Windows.Forms.CheckedListBox();
            this.textBoxMovieDiscription = new System.Windows.Forms.TextBox();
            this.textBoxMovieDuration = new System.Windows.Forms.TextBox();
            this.textBoxMovieYear = new System.Windows.Forms.TextBox();
            this.textBoxMovieCountry = new System.Windows.Forms.TextBox();
            this.textBoxMovieName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBoxDragDrob = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxApply = new System.Windows.Forms.PictureBox();
            this.textBoxAddFilm = new System.Windows.Forms.TextBox();
            this.textBoxAddPhoto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Филм.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDragDrob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApply)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Azure;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(-2, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(902, 64);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Добави филм";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDirectorLastName);
            this.groupBox1.Controls.Add(this.textBoxDirectorFirstName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(15, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 168);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режисьор";
            // 
            // textBoxDirectorLastName
            // 
            this.textBoxDirectorLastName.BackColor = System.Drawing.Color.Azure;
            this.textBoxDirectorLastName.ForeColor = System.Drawing.Color.Silver;
            this.textBoxDirectorLastName.Location = new System.Drawing.Point(6, 108);
            this.textBoxDirectorLastName.Multiline = true;
            this.textBoxDirectorLastName.Name = "textBoxDirectorLastName";
            this.textBoxDirectorLastName.Size = new System.Drawing.Size(210, 43);
            this.textBoxDirectorLastName.TabIndex = 1;
            this.textBoxDirectorLastName.Text = "Фамилия";
            this.textBoxDirectorLastName.Leave += new System.EventHandler(this.textBoxDirectorLastName_Leave);
            this.textBoxDirectorLastName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxDirectorLastName_MouseDown);
            // 
            // textBoxDirectorFirstName
            // 
            this.textBoxDirectorFirstName.BackColor = System.Drawing.Color.Azure;
            this.textBoxDirectorFirstName.ForeColor = System.Drawing.Color.Silver;
            this.textBoxDirectorFirstName.Location = new System.Drawing.Point(6, 48);
            this.textBoxDirectorFirstName.Multiline = true;
            this.textBoxDirectorFirstName.Name = "textBoxDirectorFirstName";
            this.textBoxDirectorFirstName.Size = new System.Drawing.Size(210, 43);
            this.textBoxDirectorFirstName.TabIndex = 0;
            this.textBoxDirectorFirstName.Text = "Име";
            this.textBoxDirectorFirstName.Leave += new System.EventHandler(this.textBoxDirectorFirstName_Leave);
            this.textBoxDirectorFirstName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxDirectorFirstName_MouseDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxActorWoman);
            this.groupBox2.Controls.Add(this.textBoxActorMan);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(255, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 420);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Актьори";
            // 
            // textBoxActorWoman
            // 
            this.textBoxActorWoman.BackColor = System.Drawing.Color.Azure;
            this.textBoxActorWoman.ForeColor = System.Drawing.Color.Silver;
            this.textBoxActorWoman.Location = new System.Drawing.Point(6, 239);
            this.textBoxActorWoman.Multiline = true;
            this.textBoxActorWoman.Name = "textBoxActorWoman";
            this.textBoxActorWoman.Size = new System.Drawing.Size(210, 174);
            this.textBoxActorWoman.TabIndex = 1;
            this.textBoxActorWoman.Text = "Жени";
            this.textBoxActorWoman.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxActorWoman.Leave += new System.EventHandler(this.textBoxActorWoman_Leave);
            this.textBoxActorWoman.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxActorWoman_MouseDown);
            // 
            // textBoxActorMan
            // 
            this.textBoxActorMan.BackColor = System.Drawing.Color.Azure;
            this.textBoxActorMan.ForeColor = System.Drawing.Color.Silver;
            this.textBoxActorMan.Location = new System.Drawing.Point(6, 48);
            this.textBoxActorMan.Multiline = true;
            this.textBoxActorMan.Name = "textBoxActorMan";
            this.textBoxActorMan.Size = new System.Drawing.Size(210, 174);
            this.textBoxActorMan.TabIndex = 0;
            this.textBoxActorMan.Text = "Мъже";
            this.textBoxActorMan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxActorMan.Leave += new System.EventHandler(this.textBoxActorMan_Leave);
            this.textBoxActorMan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxActorMan_MouseDown);
            // 
            // Филм
            // 
            this.Филм.Controls.Add(this.checkedListBoxMovieGenre);
            this.Филм.Controls.Add(this.textBoxMovieDiscription);
            this.Филм.Controls.Add(this.textBoxMovieDuration);
            this.Филм.Controls.Add(this.textBoxMovieYear);
            this.Филм.Controls.Add(this.textBoxMovieCountry);
            this.Филм.Controls.Add(this.textBoxMovieName);
            this.Филм.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Филм.Location = new System.Drawing.Point(495, 77);
            this.Филм.Name = "Филм";
            this.Филм.Size = new System.Drawing.Size(379, 420);
            this.Филм.TabIndex = 6;
            this.Филм.TabStop = false;
            this.Филм.Text = "Филм";
            // 
            // checkedListBoxMovieGenre
            // 
            this.checkedListBoxMovieGenre.BackColor = System.Drawing.Color.Azure;
            this.checkedListBoxMovieGenre.ForeColor = System.Drawing.Color.Silver;
            this.checkedListBoxMovieGenre.FormattingEnabled = true;
            this.checkedListBoxMovieGenre.Items.AddRange(new object[] {
            "Екшън",
            "Приключенски",
            "Комедия",
            "Криминален",
            "Фентъзи",
            "Научна фантастика",
            "Исторически",
            "Ужаси",
            "Романтичен",
            "Трилър",
            "Анимация",
            "Драма"});
            this.checkedListBoxMovieGenre.Location = new System.Drawing.Point(10, 168);
            this.checkedListBoxMovieGenre.Name = "checkedListBoxMovieGenre";
            this.checkedListBoxMovieGenre.Size = new System.Drawing.Size(360, 40);
            this.checkedListBoxMovieGenre.TabIndex = 5;
            this.checkedListBoxMovieGenre.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxMovieGenre_ItemCheck);
            this.checkedListBoxMovieGenre.Leave += new System.EventHandler(this.checkedListBoxMovieGenre_Leave);
            // 
            // textBoxMovieDiscription
            // 
            this.textBoxMovieDiscription.BackColor = System.Drawing.Color.Azure;
            this.textBoxMovieDiscription.ForeColor = System.Drawing.Color.Silver;
            this.textBoxMovieDiscription.Location = new System.Drawing.Point(10, 227);
            this.textBoxMovieDiscription.Multiline = true;
            this.textBoxMovieDiscription.Name = "textBoxMovieDiscription";
            this.textBoxMovieDiscription.Size = new System.Drawing.Size(360, 187);
            this.textBoxMovieDiscription.TabIndex = 4;
            this.textBoxMovieDiscription.Text = "Описание";
            this.textBoxMovieDiscription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMovieDiscription.Leave += new System.EventHandler(this.textBoxMovieDiscription_Leave);
            this.textBoxMovieDiscription.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxMovieDiscription_MouseDown);
            // 
            // textBoxMovieDuration
            // 
            this.textBoxMovieDuration.BackColor = System.Drawing.Color.Azure;
            this.textBoxMovieDuration.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxMovieDuration.ForeColor = System.Drawing.Color.Silver;
            this.textBoxMovieDuration.Location = new System.Drawing.Point(192, 108);
            this.textBoxMovieDuration.Multiline = true;
            this.textBoxMovieDuration.Name = "textBoxMovieDuration";
            this.textBoxMovieDuration.Size = new System.Drawing.Size(178, 43);
            this.textBoxMovieDuration.TabIndex = 3;
            this.textBoxMovieDuration.Text = "Времетраене";
            this.textBoxMovieDuration.Leave += new System.EventHandler(this.textBoxMovieDuration_Leave_1);
            this.textBoxMovieDuration.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxMovieDuration_MouseDown);
            // 
            // textBoxMovieYear
            // 
            this.textBoxMovieYear.BackColor = System.Drawing.Color.Azure;
            this.textBoxMovieYear.ForeColor = System.Drawing.Color.Silver;
            this.textBoxMovieYear.Location = new System.Drawing.Point(10, 108);
            this.textBoxMovieYear.Multiline = true;
            this.textBoxMovieYear.Name = "textBoxMovieYear";
            this.textBoxMovieYear.Size = new System.Drawing.Size(178, 43);
            this.textBoxMovieYear.TabIndex = 2;
            this.textBoxMovieYear.Text = "Година";
            this.textBoxMovieYear.Leave += new System.EventHandler(this.textBoxMovieYear_Leave);
            this.textBoxMovieYear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxMovieYear_MouseDown_1);
            // 
            // textBoxMovieCountry
            // 
            this.textBoxMovieCountry.BackColor = System.Drawing.Color.Azure;
            this.textBoxMovieCountry.ForeColor = System.Drawing.Color.Silver;
            this.textBoxMovieCountry.Location = new System.Drawing.Point(192, 48);
            this.textBoxMovieCountry.Multiline = true;
            this.textBoxMovieCountry.Name = "textBoxMovieCountry";
            this.textBoxMovieCountry.Size = new System.Drawing.Size(178, 43);
            this.textBoxMovieCountry.TabIndex = 1;
            this.textBoxMovieCountry.Text = "Държава";
            this.textBoxMovieCountry.Leave += new System.EventHandler(this.textBoxMovieCountry_Leave);
            this.textBoxMovieCountry.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxMovieCountry_MouseDown);
            // 
            // textBoxMovieName
            // 
            this.textBoxMovieName.BackColor = System.Drawing.Color.Azure;
            this.textBoxMovieName.ForeColor = System.Drawing.Color.Silver;
            this.textBoxMovieName.Location = new System.Drawing.Point(10, 48);
            this.textBoxMovieName.Multiline = true;
            this.textBoxMovieName.Name = "textBoxMovieName";
            this.textBoxMovieName.Size = new System.Drawing.Size(178, 43);
            this.textBoxMovieName.TabIndex = 0;
            this.textBoxMovieName.Text = "Име";
            this.textBoxMovieName.Leave += new System.EventHandler(this.textBoxMovieName_Leave);
            this.textBoxMovieName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxMovieName_MouseDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBoxDragDrob);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(15, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 244);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Снимка";
            // 
            // pictureBoxDragDrob
            // 
            this.pictureBoxDragDrob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDragDrob.Image = global::MoviesApp.Properties.Resources.images;
            this.pictureBoxDragDrob.Location = new System.Drawing.Point(6, 39);
            this.pictureBoxDragDrob.Name = "pictureBoxDragDrob";
            this.pictureBoxDragDrob.Size = new System.Drawing.Size(203, 198);
            this.pictureBoxDragDrob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDragDrob.TabIndex = 0;
            this.pictureBoxDragDrob.TabStop = false;
            this.pictureBoxDragDrob.Click += new System.EventHandler(this.pictureBoxDragDrob_Click);
            this.pictureBoxDragDrob.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBoxDragDrob_DragDrop);
            this.pictureBoxDragDrob.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBoxDragDrob_DragEnter);
            this.pictureBoxDragDrob.MouseEnter += new System.EventHandler(this.pictureBoxDragDrob_MouseEnter);
            this.pictureBoxDragDrob.MouseLeave += new System.EventHandler(this.pictureBoxDragDrob_MouseLeave);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = global::MoviesApp.Properties.Resources.backArrows;
            this.pictureBoxBack.Location = new System.Drawing.Point(42, 508);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(64, 62);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 8;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // pictureBoxApply
            // 
            this.pictureBoxApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxApply.Image = global::MoviesApp.Properties.Resources.img_464408;
            this.pictureBoxApply.Location = new System.Drawing.Point(767, 508);
            this.pictureBoxApply.Name = "pictureBoxApply";
            this.pictureBoxApply.Size = new System.Drawing.Size(79, 62);
            this.pictureBoxApply.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxApply.TabIndex = 9;
            this.pictureBoxApply.TabStop = false;
            this.pictureBoxApply.Click += new System.EventHandler(this.pictureBoxApply_Click);
            this.pictureBoxApply.MouseEnter += new System.EventHandler(this.pictureBoxApply_MouseEnter);
            this.pictureBoxApply.MouseLeave += new System.EventHandler(this.pictureBoxApply_MouseLeave);
            // 
            // textBoxAddFilm
            // 
            this.textBoxAddFilm.BackColor = System.Drawing.Color.Azure;
            this.textBoxAddFilm.Location = new System.Drawing.Point(699, 508);
            this.textBoxAddFilm.Multiline = true;
            this.textBoxAddFilm.Name = "textBoxAddFilm";
            this.textBoxAddFilm.Size = new System.Drawing.Size(68, 29);
            this.textBoxAddFilm.TabIndex = 10;
            this.textBoxAddFilm.Text = "добави";
            this.textBoxAddFilm.Visible = false;
            // 
            // textBoxAddPhoto
            // 
            this.textBoxAddPhoto.BackColor = System.Drawing.Color.Azure;
            this.textBoxAddPhoto.Location = new System.Drawing.Point(161, 480);
            this.textBoxAddPhoto.Multiline = true;
            this.textBoxAddPhoto.Name = "textBoxAddPhoto";
            this.textBoxAddPhoto.Size = new System.Drawing.Size(69, 49);
            this.textBoxAddPhoto.TabIndex = 11;
            this.textBoxAddPhoto.Text = "добави снимка";
            this.textBoxAddPhoto.Visible = false;
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(888, 585);
            this.Controls.Add(this.textBoxAddPhoto);
            this.Controls.Add(this.textBoxAddFilm);
            this.Controls.Add(this.pictureBoxApply);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Филм);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddMovieForm";
            this.Text = "MovieApp";
            this.Load += new System.EventHandler(this.AddMovieForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Филм.ResumeLayout(false);
            this.Филм.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDragDrob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApply)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDirectorLastName;
        private System.Windows.Forms.TextBox textBoxDirectorFirstName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxActorWoman;
        private System.Windows.Forms.TextBox textBoxActorMan;
        private System.Windows.Forms.GroupBox Филм;
        private System.Windows.Forms.TextBox textBoxMovieCountry;
        private System.Windows.Forms.TextBox textBoxMovieName;
        private System.Windows.Forms.TextBox textBoxMovieDuration;
        private System.Windows.Forms.TextBox textBoxMovieYear;
        private System.Windows.Forms.CheckedListBox checkedListBoxMovieGenre;
        private System.Windows.Forms.TextBox textBoxMovieDiscription;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBoxDragDrob;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBoxApply;
        private System.Windows.Forms.TextBox textBoxAddFilm;
        private System.Windows.Forms.TextBox textBoxAddPhoto;
    }
}