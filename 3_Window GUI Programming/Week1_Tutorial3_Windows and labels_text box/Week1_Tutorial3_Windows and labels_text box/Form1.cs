using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1_Tutorial3_Windows_and_labels_text_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //essageBox.Show("Resize!");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click!");

            textBox1.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("double Click!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click!");
        }
    }
}
