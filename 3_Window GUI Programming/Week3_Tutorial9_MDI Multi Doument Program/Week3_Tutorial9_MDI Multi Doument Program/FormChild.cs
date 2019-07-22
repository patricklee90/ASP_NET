using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3_Tutorial9_MDI_Multi_Doument_Program
{
    public partial class FormChild : Form
    {
        public FormChild()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void LoadPic(string filename)
        {
            pictureBox1.Image = Image.FromFile(filename);
        }
    }
}
