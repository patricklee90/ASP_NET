using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Week3_Tutorial8_Drawing_Program
{
    public partial class Form1 : Form
    {
        private Pen myPen = new Pen(Color.Red, 2);
        private Bitmap bitmap;
        private bool mouse_captured = false;
        private Point p1, p2;

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MI2.Checked = false;
            MI5.Checked = false;
            MI10.Checked = true;

            myPen.Width = 10;
        }

        private void MI2_Click(object sender, EventArgs e)
        {
            MI2.Checked = true;
            MI5.Checked = false;
            MI10.Checked = false;

            myPen.Width = 2;
        }

        private void MI5_Click(object sender, EventArgs e)
        {
            MI2.Checked = false;
            MI5.Checked = true;
            MI10.Checked = false;

            myPen.Width = 5;
        }

        private void MISolid_Click(object sender, EventArgs e)
        {
            MISolid.Checked = true;
            MIDotted.Checked = false;

            myPen.DashStyle = DashStyle.Solid;
        }

        private void MIDotted_Click(object sender, EventArgs e)
        {
            MISolid.Checked = false;
            MIDotted.Checked = true;

            myPen.DashStyle = DashStyle.Dash;
        }

        private void selectColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                myPen.Color = colorDialog1.Color;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if(bitmap != null)
            {
                e.Graphics.DrawImage(bitmap,0,0);

            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewPic fnew = new FormNewPic();

            if(fnew.ShowDialog() == DialogResult.OK)
            {
                bitmap = new Bitmap(fnew.imagewidth, fnew.imageheight);
                Brush whiteBrush = new SolidBrush(Color.White);
                Graphics g = Graphics.FromImage(bitmap);

                g.FillRectangle(whiteBrush, 0, 0, fnew.imagewidth, fnew.imageheight);
                Invalidate();

            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && e.X < bitmap.Width && e.Y < bitmap.Height)
            {
                mouse_captured = true;
                p1.X = e.X;
                p1.Y = e.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                mouse_captured = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouse_captured)
                return;

            if (e.X < bitmap.Width && e.Y < bitmap.Height)
            {
                p2.X = e.X;
                p2.Y = e.Y;

                Graphics g = Graphics.FromImage(bitmap);

                g.DrawLine(myPen, p1, p2);
                p1.X = e.X;
                p1.Y = e.Y;
                Invalidate();
            }
        }
    }
}
