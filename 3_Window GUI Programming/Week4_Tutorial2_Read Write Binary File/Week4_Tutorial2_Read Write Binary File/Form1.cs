using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Week4_Tutorial2_Read_Write_Binary_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int age = (int)numericUpDown1.Value;
            float weight = (float)numericUpDown2.Value;

            FileStream fs = new FileStream("D:\\people.bin", FileMode.Create, FileAccess.Write);

            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(name);
            bw.Write(age);
            bw.Write(weight);

            bw.Close();
            fs.Close();

            MessageBox.Show("Successfully Write!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("D:\\people.bin", FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);

            textBox1.Text = br.ReadString();
            numericUpDown1.Value = br.ReadInt32();
            numericUpDown2.Value = Convert.ToDecimal(br.ReadSingle());
            
            br.Close();
            fs.Close();

            MessageBox.Show("Successfully Read!");
        }
    }
}
