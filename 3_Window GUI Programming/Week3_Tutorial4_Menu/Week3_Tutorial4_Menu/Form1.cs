using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3_Tutorial4_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Create";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Open";
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Text = "Exit";
        }

        private void expandListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Expand List";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "About";
        }

        private void testingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Testing";
        }

        private void testing2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Testing 2";
        }
    }
}
