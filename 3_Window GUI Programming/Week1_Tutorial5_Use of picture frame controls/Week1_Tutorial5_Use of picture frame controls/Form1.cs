using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1_Tutorial5_Use_of_picture_frame_controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int ind = -1;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ind++;

            if (ind % 3 == 0)
            {
                pictureBox1.ImageLocation = "C:\\Users\\ricky\\Desktop\\phonepicutres-TA.jpg";
            }

            if (ind % 3 == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\ricky\\Desktop\\google drive.png";
            }
            if (ind % 3 == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\ricky\\Desktop\\Captureff.PNG";
            }
        }
    }
}
