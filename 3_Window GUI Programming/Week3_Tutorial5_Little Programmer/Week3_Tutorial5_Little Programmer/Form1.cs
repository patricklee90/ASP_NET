using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3_Tutorial5_Little_Programmer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Textbox Content has been saved! \n" + textBox1.Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }
    }
}
