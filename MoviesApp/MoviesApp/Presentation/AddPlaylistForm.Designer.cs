﻿
namespace MoviesApp.Presentation
{
    partial class AddPlaylistForm
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
            this.dataGridViewPlaylists = new System.Windows.Forms.DataGridView();
            this.labelChoose = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaylists)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPlaylists
            // 
            this.dataGridViewPlaylists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlaylists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewPlaylists.Location = new System.Drawing.Point(155, 12);
            this.dataGridViewPlaylists.Name = "dataGridViewPlaylists";
            this.dataGridViewPlaylists.RowHeadersWidth = 4;
            this.dataGridViewPlaylists.RowTemplate.Height = 29;
            this.dataGridViewPlaylists.Size = new System.Drawing.Size(141, 288);
            this.dataGridViewPlaylists.TabIndex = 0;
            this.dataGridViewPlaylists.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlaylists_CellContentClick);
            // 
            // labelChoose
            // 
            this.labelChoose.AutoSize = true;
            this.labelChoose.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelChoose.Location = new System.Drawing.Point(12, 12);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(98, 31);
            this.labelChoose.TabIndex = 1;
            this.labelChoose.Text = "ИЗБЕРИ";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(155, 306);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(141, 61);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добави";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddPlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 370);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelChoose);
            this.Controls.Add(this.dataGridViewPlaylists);
            this.Name = "AddPlaylistForm";
            this.Text = "AddPlaylistForm";
            this.Load += new System.EventHandler(this.AddPlaylistForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaylists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPlaylists;
        private System.Windows.Forms.Label labelChoose;
        private System.Windows.Forms.Button buttonAdd;
    }
}