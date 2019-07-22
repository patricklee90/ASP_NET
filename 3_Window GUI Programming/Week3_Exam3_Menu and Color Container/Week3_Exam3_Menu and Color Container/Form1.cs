using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3_Exam3_Menu_and_Color_Container
{
    public partial class Form1 : Form
    {
        Pen myPen = new Pen(Color.CadetBlue, 2);
        SolidBrush myBrush = new SolidBrush(Color.Red);
        public Form1()
        {
            InitializeComponent();
        }

        private void drawLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen myPen = new Pen(Color.Blue, 2);
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawLine(myPen, 100, 100, 200, 200);
            formGraphics.DrawLine(myPen, 200, 200, 256, 87);
            formGraphics.DrawLine(myPen, 256, 87, 87, 9);
            formGraphics.DrawLine(myPen, 87, 9, 22, 108);
        }

        private void drawOvalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(myBrush, 100, 100, 500, 250); myBrush.Dispose();
        }

        private void selectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                myPen = new Pen(colorDialog1.Color, 2);
                myBrush = new SolidBrush(colorDialog1.Color);
            }
        }
    }
}
