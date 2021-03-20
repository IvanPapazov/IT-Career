
namespace MoviesApp.Presentation
{
    partial class PlaylistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistForm));
            this.dataGridViewPlaylist = new System.Windows.Forms.DataGridView();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPlaylists = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRename = new System.Windows.Forms.Button();
            this.buttonSave2 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewFilms = new System.Windows.Forms.DataGridView();
            this.labelFilms = new System.Windows.Forms.Label();
            this.textBoxFilm = new System.Windows.Forms.TextBox();
            this.buttonDeleteMovie = new System.Windows.Forms.Button();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPlaylist
            // 
            this.dataGridViewPlaylist.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewPlaylist.Location = new System.Drawing.Point(253, 70);
            this.dataGridViewPlaylist.Name = "dataGridViewPlaylist";
            this.dataGridViewPlaylist.RowHeadersWidth = 4;
            this.dataGridViewPlaylist.RowTemplate.Height = 29;
            this.dataGridViewPlaylist.Size = new System.Drawing.Size(153, 234);
            this.dataGridViewPlaylist.TabIndex = 0;
            this.dataGridViewPlaylist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlaylist_CellContentClick);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(35, 72);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(182, 38);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPlaylists
            // 
            this.labelPlaylists.AutoSize = true;
            this.labelPlaylists.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlaylists.Location = new System.Drawing.Point(340, 9);
            this.labelPlaylists.Name = "labelPlaylists";
            this.labelPlaylists.Size = new System.Drawing.Size(164, 41);
            this.labelPlaylists.TabIndex = 2;
            this.labelPlaylists.Text = "Плейлисти";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Silver;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(35, 138);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(182, 38);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добави";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            this.buttonAdd.MouseEnter += new System.EventHandler(this.buttonAdd_MouseEnter);
            this.buttonAdd.MouseLeave += new System.EventHandler(this.buttonAdd_MouseLeave);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.BackColor = System.Drawing.Color.Azure;
            this.textBoxAdd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAdd.Location = new System.Drawing.Point(35, 72);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(182, 38);
            this.textBoxAdd.TabIndex = 4;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.LightBlue;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(35, 138);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(182, 38);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Запази";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.buttonSave.MouseEnter += new System.EventHandler(this.buttonSave_MouseEnter);
            this.buttonSave.MouseLeave += new System.EventHandler(this.buttonSave_MouseLeave);
            // 
            // buttonRename
            // 
            this.buttonRename.BackColor = System.Drawing.Color.LightBlue;
            this.buttonRename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRename.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRename.Location = new System.Drawing.Point(35, 201);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(182, 41);
            this.buttonRename.TabIndex = 7;
            this.buttonRename.Text = "Преименувай";
            this.buttonRename.UseVisualStyleBackColor = false;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            this.buttonRename.MouseEnter += new System.EventHandler(this.buttonRename_MouseEnter);
            this.buttonRename.MouseLeave += new System.EventHandler(this.buttonRename_MouseLeave);
            // 
            // buttonSave2
            // 
            this.buttonSave2.BackColor = System.Drawing.Color.Silver;
            this.buttonSave2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave2.Location = new System.Drawing.Point(35, 201);
            this.buttonSave2.Name = "buttonSave2";
            this.buttonSave2.Size = new System.Drawing.Size(182, 41);
            this.buttonSave2.TabIndex = 6;
            this.buttonSave2.Text = "Запази";
            this.buttonSave2.UseVisualStyleBackColor = false;
            this.buttonSave2.Click += new System.EventHandler(this.buttonSave2_Click);
            this.buttonSave2.MouseEnter += new System.EventHandler(this.buttonSave2_MouseEnter);
            this.buttonSave2.MouseLeave += new System.EventHandler(this.buttonSave2_MouseLeave);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.LightBlue;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(35, 263);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(182, 41);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Изтрий";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            this.buttonDelete.MouseEnter += new System.EventHandler(this.buttonDelete_MouseEnter);
            this.buttonDelete.MouseLeave += new System.EventHandler(this.buttonDelete_MouseLeave);
            // 
            // dataGridViewFilms
            // 
            this.dataGridViewFilms.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewFilms.Location = new System.Drawing.Point(412, 70);
            this.dataGridViewFilms.Name = "dataGridViewFilms";
            this.dataGridViewFilms.RowHeadersWidth = 4;
            this.dataGridViewFilms.RowTemplate.Height = 29;
            this.dataGridViewFilms.Size = new System.Drawing.Size(155, 234);
            this.dataGridViewFilms.TabIndex = 9;
            this.dataGridViewFilms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFilms_CellContentClick);
            // 
            // labelFilms
            // 
            this.labelFilms.AutoSize = true;
            this.labelFilms.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFilms.Location = new System.Drawing.Point(689, 70);
            this.labelFilms.Name = "labelFilms";
            this.labelFilms.Size = new System.Drawing.Size(111, 41);
            this.labelFilms.TabIndex = 10;
            this.labelFilms.Text = "Филми";
            // 
            // textBoxFilm
            // 
            this.textBoxFilm.BackColor = System.Drawing.Color.Azure;
            this.textBoxFilm.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFilm.Location = new System.Drawing.Point(603, 138);
            this.textBoxFilm.Name = "textBoxFilm";
            this.textBoxFilm.Size = new System.Drawing.Size(274, 38);
            this.textBoxFilm.TabIndex = 11;
            // 
            // buttonDeleteMovie
            // 
            this.buttonDeleteMovie.BackColor = System.Drawing.Color.LightBlue;
            this.buttonDeleteMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteMovie.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteMovie.Location = new System.Drawing.Point(603, 263);
            this.buttonDeleteMovie.Name = "buttonDeleteMovie";
            this.buttonDeleteMovie.Size = new System.Drawing.Size(274, 41);
            this.buttonDeleteMovie.TabIndex = 12;
            this.buttonDeleteMovie.Text = "Изтрий Филм";
            this.buttonDeleteMovie.UseVisualStyleBackColor = false;
            this.buttonDeleteMovie.Click += new System.EventHandler(this.buttonDeleteMovie_Click);
            this.buttonDeleteMovie.MouseEnter += new System.EventHandler(this.buttonDeleteMovie_MouseEnter);
            this.buttonDeleteMovie.MouseLeave += new System.EventHandler(this.buttonDeleteMovie_MouseLeave);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::MoviesApp.Properties.Resources.backArrows;
            this.pictureBoxBack.Location = new System.Drawing.Point(12, 4);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(55, 46);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 13;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // PlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(901, 327);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.buttonDeleteMovie);
            this.Controls.Add(this.textBoxFilm);
            this.Controls.Add(this.labelFilms);
            this.Controls.Add(this.dataGridViewFilms);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRename);
            this.Controls.Add(this.buttonSave2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelPlaylists);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridViewPlaylist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PlaylistForm";
            this.Text = "MovieApp";
            this.Load += new System.EventHandler(this.PlaylistForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPlaylist;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPlaylists;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.Button buttonSave2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewFilms;
        private System.Windows.Forms.Label labelFilms;
        private System.Windows.Forms.TextBox textBoxFilm;
        private System.Windows.Forms.Button buttonDeleteMovie;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}