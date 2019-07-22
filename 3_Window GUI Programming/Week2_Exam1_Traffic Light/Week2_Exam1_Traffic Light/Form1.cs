using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2_Exam1_Traffic_Light
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            textBox1.BackColor = Color.Gray;
            textBox2.BackColor = Color.Gray;
            textBox3.BackColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private int position=1;
        private int count = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count % 10 == 0)
            {
                count = 1;
            }

            switch (count)
            {
                case 1:
                    textBox1.BackColor = Color.Red;
                    textBox2.BackColor = Color.Gray;
                    textBox3.BackColor = Color.Gray;
                    break;
                case 2:
                    textBox1.BackColor = Color.Green;
                    break;
                case 3:
                    textBox1.BackColor = Color.Yellow;
                    break;
                case 4:
                    textBox1.BackColor = Color.Gray;
                    textBox2.BackColor = Color.Red;
                    textBox3.BackColor = Color.Gray;
                    break;
                case 5:
                    textBox2.BackColor = Color.Green;
                    break;
                case 6:
                    textBox2.BackColor = Color.Yellow;
                    break;
                case 7:
                    textBox1.BackColor = Color.Gray;
                    textBox2.BackColor = Color.Gray;
                    textBox3.BackColor = Color.Red;
                    break;
                case 8:
                    textBox3.BackColor = Color.Green;
                    break;
                case 9:
                    textBox3.BackColor = Color.Yellow;
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 9)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                button1.Visible = true;
                button2.Visible = true;

                timer1.Enabled = true;
            }
        }
    }
}
