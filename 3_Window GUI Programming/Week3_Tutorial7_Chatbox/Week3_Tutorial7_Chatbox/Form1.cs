using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3_Tutorial7_Chatbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you sure to exit?","Hint",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

        }
    }
}
