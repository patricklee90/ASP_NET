using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2_Tutorial4_Mouse_Event
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

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = e.X.ToString();
            textBox2.Text = e.Y.ToString();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel4.BackColor = panel1.BackColor;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            panel4.BackColor = panel2.BackColor;
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            panel4.BackColor = panel3.BackColor;
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Label la = new Label();
            la.Location = new Point(e.X, e.Y);
            la.Text = "     ";
            la.BackColor = panel4.BackColor;

            this.Controls.Add(la);
        }
    }
}
