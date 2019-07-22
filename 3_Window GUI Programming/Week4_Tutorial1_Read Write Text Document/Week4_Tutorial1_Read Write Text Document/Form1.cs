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

namespace Week4_Tutorial1_Read_Write_Text_Document
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text File|*.txt";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    sw.Write(textBox1.Text);

                    sw.Close();
                }
                catch
                {
                    MessageBox.Show("Write Error");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text File|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);

                    textBox1.Clear();
                    textBox1.Text = sr.ReadToEnd();

                    sr.Close();
                }
                catch
                {
                    MessageBox.Show("Read Error");
                }
            }
        }
    }
}
