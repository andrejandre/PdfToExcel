using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfToExcel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1.Text = "Github Repo";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/andrejandre/PdfToExcel");

        }
    }
}
