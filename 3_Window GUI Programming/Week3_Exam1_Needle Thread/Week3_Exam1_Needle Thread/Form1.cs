using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3_Exam1_Needle_Thread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Blue, 2);
            Graphics g = e.Graphics;
            g.DrawLine(myPen, 100, 100, 200, 200);
            g.DrawLine(myPen, 200, 200, 256, 87);
            g.DrawLine(myPen, 256, 87, 87, 9);
            g.DrawLine(myPen, 87, 9, 22, 108);
        }
    }
}
