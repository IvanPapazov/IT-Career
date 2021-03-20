
namespace MoviesApp.Resources
{
    partial class Film
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Film));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.textBoxActors = new System.Windows.Forms.TextBox();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.pictureBoxHeart = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlus = new System.Windows.Forms.PictureBox();
            this.pictureBoxClock = new System.Windows.Forms.PictureBox();
            this.pictureBoxYear = new System.Windows.Forms.PictureBox();
            this.pictureBoxCountry = new System.Windows.Forms.PictureBox();
            this.pictureBoxGoLink = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoLink)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(486, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 459);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Enabled = false;
            this.labelYear.Font = new System.Drawing.Font("Segoe UI", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelYear.Location = new System.Drawing.Point(37, 105);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(0, 30);
            this.labelYear.TabIndex = 3;
            this.labelYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelYear.Click += new System.EventHandler(this.labelYear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(180, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Актьори";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(379, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Описание";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(174, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 35);
            this.label4.TabIndex = 7;
            this.label4.Text = "Режисьор";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Enabled = false;
            this.labelDuration.Font = new System.Drawing.Font("Segoe UI", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelDuration.Location = new System.Drawing.Point(165, 105);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(0, 30);
            this.labelDuration.TabIndex = 8;
            this.labelDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDuration.Click += new System.EventHandler(this.labelDuration_Click);
            // 
            // textBoxActors
            // 
            this.textBoxActors.BackColor = System.Drawing.Color.Azure;
            this.textBoxActors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxActors.Enabled = false;
            this.textBoxActors.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBoxActors.Location = new System.Drawing.Point(16, 350);
            this.textBoxActors.Multiline = true;
            this.textBoxActors.Name = "textBoxActors";
            this.textBoxActors.ReadOnly = true;
            this.textBoxActors.Size = new System.Drawing.Size(432, 195);
            this.textBoxActors.TabIndex = 9;
            this.textBoxActors.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxActors.TextChanged += new System.EventHandler(this.textBoxActors_TextChanged);
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.BackColor = System.Drawing.Color.Azure;
            this.textBoxDirector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDirector.Enabled = false;
            this.textBoxDirector.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBoxDirector.Location = new System.Drawing.Point(11, 231);
            this.textBoxDirector.Multiline = true;
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.ReadOnly = true;
            this.textBoxDirector.Size = new System.Drawing.Size(432, 61);
            this.textBoxDirector.TabIndex = 11;
            this.textBoxDirector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDirector.TextChanged += new System.EventHandler(this.textBoxDirector_TextChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.Azure;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Enabled = false;
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBoxDescription.Location = new System.Drawing.Point(16, 588);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(937, 226);
            this.textBoxDescription.TabIndex = 14;
            this.textBoxDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Azure;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(920, 680);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.Azure;
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Enabled = false;
            this.textBoxTitle.Font = new System.Drawing.Font("Segoe UI", 16.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBoxTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxTitle.Location = new System.Drawing.Point(72, 1);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(753, 79);
            this.textBoxTitle.TabIndex = 12;
            this.textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBack.Image")));
            this.pictureBoxBack.Location = new System.Drawing.Point(11, 10);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(55, 49);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 18;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.BackColor = System.Drawing.Color.Azure;
            this.textBoxCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCountry.Enabled = false;
            this.textBoxCountry.Font = new System.Drawing.Font("Segoe UI", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBoxCountry.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxCountry.Location = new System.Drawing.Point(270, 105);
            this.textBoxCountry.Multiline = true;
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.ReadOnly = true;
            this.textBoxCountry.Size = new System.Drawing.Size(210, 54);
            this.textBoxCountry.TabIndex = 19;
            // 
            // pictureBoxHeart
            // 
            this.pictureBoxHeart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHeart.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHeart.Image")));
            this.pictureBoxHeart.Location = new System.Drawing.Point(898, 15);
            this.pictureBoxHeart.Name = "pictureBoxHeart";
            this.pictureBoxHeart.Size = new System.Drawing.Size(55, 49);
            this.pictureBoxHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHeart.TabIndex = 20;
            this.pictureBoxHeart.TabStop = false;
            this.pictureBoxHeart.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBoxHeart.MouseEnter += new System.EventHandler(this.pictureBoxHeart_MouseEnter);
            this.pictureBoxHeart.MouseLeave += new System.EventHandler(this.pictureBoxHeart_MouseLeave);
            // 
            // pictureBoxPlus
            // 
            this.pictureBoxPlus.BackColor = System.Drawing.Color.Azure;
            this.pictureBoxPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPlus.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlus.Image")));
            this.pictureBoxPlus.Location = new System.Drawing.Point(831, 15);
            this.pictureBoxPlus.Name = "pictureBoxPlus";
            this.pictureBoxPlus.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlus.TabIndex = 21;
            this.pictureBoxPlus.TabStop = false;
            this.pictureBoxPlus.Click += new System.EventHandler(this.pictureBoxPlus_Click_1);
            // 
            // pictureBoxClock
            // 
            this.pictureBoxClock.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClock.Image")));
            this.pictureBoxClock.Location = new System.Drawing.Point(129, 110);
            this.pictureBoxClock.Name = "pictureBoxClock";
            this.pictureBoxClock.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClock.TabIndex = 22;
            this.pictureBoxClock.TabStop = false;
            // 
            // pictureBoxYear
            // 
            this.pictureBoxYear.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxYear.Image")));
            this.pictureBoxYear.Location = new System.Drawing.Point(1, 110);
            this.pictureBoxYear.Name = "pictureBoxYear";
            this.pictureBoxYear.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxYear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxYear.TabIndex = 23;
            this.pictureBoxYear.TabStop = false;
            // 
            // pictureBoxCountry
            // 
            this.pictureBoxCountry.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCountry.Image")));
            this.pictureBoxCountry.Location = new System.Drawing.Point(234, 110);
            this.pictureBoxCountry.Name = "pictureBoxCountry";
            this.pictureBoxCountry.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCountry.TabIndex = 24;
            this.pictureBoxCountry.TabStop = false;
            // 
            // pictureBoxGoLink
            // 
            this.pictureBoxGoLink.Image = global::MoviesApp.Properties.Resources.goLink;
            this.pictureBoxGoLink.Location = new System.Drawing.Point(706, 291);
            this.pictureBoxGoLink.Name = "pictureBoxGoLink";
            this.pictureBoxGoLink.Size = new System.Drawing.Size(49, 48);
            this.pictureBoxGoLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGoLink.TabIndex = 25;
            this.pictureBoxGoLink.TabStop = false;
            this.pictureBoxGoLink.Visible = false;
            this.pictureBoxGoLink.Click += new System.EventHandler(this.pictureBoxGoLink_Click);
            // 
            // Film
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(963, 713);
            this.Controls.Add(this.pictureBoxGoLink);
            this.Controls.Add(this.pictureBoxCountry);
            this.Controls.Add(this.pictureBoxYear);
            this.Controls.Add(this.pictureBoxClock);
            this.Controls.Add(this.pictureBoxPlus);
            this.Controls.Add(this.pictureBoxHeart);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxDirector);
            this.Controls.Add(this.textBoxActors);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Film";
            this.Text = "MovieApp";
            this.Load += new System.EventHandler(this.Film_Load);
            this.MouseEnter += new System.EventHandler(this.Film_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoLink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.TextBox textBoxActors;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.PictureBox pictureBoxHeart;
        private System.Windows.Forms.PictureBox pictureBoxPlus;
        private System.Windows.Forms.PictureBox pictureBoxClock;
        private System.Windows.Forms.PictureBox pictureBoxYear;
        private System.Windows.Forms.PictureBox pictureBoxCountry;
        private System.Windows.Forms.PictureBox pictureBoxGoLink;
    }
}