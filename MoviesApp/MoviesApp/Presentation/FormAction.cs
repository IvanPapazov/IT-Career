using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MoviesApp.Presentation
{
    public partial class FormAction : Form
    {
        public FormAction()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.myForm.Show(); 
        }
    }
}
