using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3_Tutorial1_Brush_and_Color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.CadetBlue, 2);
            Graphics g = e.Graphics;

            // Draw Straight Line
            g.DrawLine(myPen, 10, 10, 200, 10);

            // Draw Diagonal Line
            myPen.DashStyle = DashStyle.Dash;
            g.DrawLine(myPen, 10, 60, 200, 60);

            // Draw Dot Line
            myPen.DashStyle = DashStyle.DashDot;
            g.DrawLine(myPen, 10, 110, 200, 110);

            myPen.DashStyle = DashStyle.Solid;
            myPen.Color = Color.Red;
            myPen.Width = 5;
            myPen.EndCap = LineCap.ArrowAnchor;
            g.DrawLine(myPen, 10, 160, 200, 160);

            myPen.Color = Color.FromArgb(128, 0, 108);
            myPen.EndCap = LineCap.NoAnchor;
            myPen.StartCap = LineCap.DiamondAnchor;
            g.DrawLine(myPen, 10, 218, 200, 218);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen myPen = new Pen(Color.Yellow, 2);

            // Draw Straight Line
            g.DrawLine(myPen, 10, 30, 200, 30);
        }
    }
}
