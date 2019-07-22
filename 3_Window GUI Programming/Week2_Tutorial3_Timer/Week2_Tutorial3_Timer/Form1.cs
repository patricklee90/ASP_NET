using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2_Tutorial3_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;

        }

        private int d = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int px = label1.Location.X;
            int py = label1.Location.Y;

            px+=d;
            label1.Location = new Point(px%420, py);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            d = (int)numericUpDown1.Value;
        }
    }
}
