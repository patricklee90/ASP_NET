using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3_Exam2_Drawing_Oval
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
            SolidBrush RedBrush = new SolidBrush(Color.Red);
            g.FillEllipse(RedBrush, 100, 100, 500, 250);

        }
    }
}
