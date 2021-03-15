using System;
using System.Windows.Forms;
using MoviesApp.Data.Model;
using System.Drawing;
using MoviesApp.Presentation;
using System.IO;

namespace MoviesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            EnsureDateBaseIsCreated();
            pictureBox2.AllowDrop = true;
        }
        private void EnsureDateBaseIsCreated()
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
            groupBox1.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Silver;

        }


        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //PictureBox pictureBox = new PictureBox();
            //pictureBox.Parent = Program.myForm;
            //pictureBox.Image = Image.FromFile("55.jpg");
            //pictureBox.Location = new Point(253, 25);
            //pictureBox.Size = new Size(100,100);
            //pictureBox.Visible = true;
            //pictureBox.BringToFront();
            //pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var formAction = new FormAction();
            formAction.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var formAction = new FormAction();
            formAction.Show();
            this.Hide();
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var filename = data as string[];
                if (filename.Length > 0)
                {
                    pictureBox2.Image = Image.FromFile(filename[0]);
                }
            }
        }
        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
