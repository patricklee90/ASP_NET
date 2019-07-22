using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3_Tutorial3_Drawing_at_Controller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool drawing = false;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (drawing)
            {
                Graphics g = textBox1.CreateGraphics();

                SolidBrush RedBrush = new SolidBrush(Color.Red);
                SolidBrush YellowBrush = new SolidBrush(Color.Yellow);
                SolidBrush BlueBrush = new SolidBrush(Color.Blue);

                g.FillEllipse(RedBrush, 0, 0, textBox1.Size.Width / 2, textBox1.Size.Height / 2);
                g.FillEllipse(YellowBrush, 0, textBox1.Size.Width / 2, textBox1.Size.Width / 2, textBox1.Size.Height / 2);
                g.FillEllipse(BlueBrush, textBox1.Size.Height / 2, 0, textBox1.Size.Width / 2, textBox1.Size.Height / 2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawing = true;
            Invalidate(new Rectangle(textBox1.Location, textBox1.Size));
        }
    }
}
