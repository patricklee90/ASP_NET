using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2_Tutorial2_Use_of_digital_adjustment_controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            decimal p = Convert.ToDecimal(textBox1.Text);
            decimal r = numericUpDown1.Value;

            decimal amount = p * (decimal)Math.Pow((Double)(1 + r), (int)numericUpDown2.Value);

            textBox2.Text = amount.ToString();
        }
    }
}
