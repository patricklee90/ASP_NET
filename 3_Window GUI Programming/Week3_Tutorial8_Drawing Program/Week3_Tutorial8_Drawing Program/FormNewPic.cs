using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3_Tutorial8_Drawing_Program
{
    public partial class FormNewPic : Form
    {
        public int imagewidth;
        public int imageheight;

        public FormNewPic()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            imagewidth = (int)numericUpDown1.Value;
            imageheight = (int)numericUpDown2.Value;
        }
    }
}
