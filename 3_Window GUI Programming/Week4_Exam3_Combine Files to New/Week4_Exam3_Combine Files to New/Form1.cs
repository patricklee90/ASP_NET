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

namespace Week4_Exam3_Combine_Files_to_New
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text File|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);

                    textBox1.Clear();
                    textBox1.Text = sr.ReadToEnd();
                    label1.Text = openFileDialog1.FileName;
                    sr.Close();
                }
                catch
                {
                    MessageBox.Show("Read Error");
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

                    textBox2.Clear();
                    textBox2.Text = sr.ReadToEnd();
                    label2.Text = openFileDialog1.FileName;
                    sr.Close();
                }
                catch
                {
                    MessageBox.Show("Read Error");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text + textBox2.Text;
            textBox4.Text = textBox2.Text + textBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string File1 =Path.GetFileNameWithoutExtension(label1.Text) + "_new.txt";
                string Dir1 = Path.GetDirectoryName(label1.Text);
                StreamWriter sw = new StreamWriter(Dir1+"\\"+File1);
                sw.Write(textBox3.Text);
                sw.Close();

                string File2 = Path.GetFileNameWithoutExtension(label2.Text) + "_new.txt";
                string Dir2 = Path.GetDirectoryName(label2.Text);
                StreamWriter sw2 = new StreamWriter(Dir2 + "\\" + File2);
                sw2.Write(textBox4.Text);
                sw2.Close();

                File.Delete(label1.Text);
                File.Delete(label2.Text);
            }
            catch
            {
                MessageBox.Show("Write Error");
            }
        }
    }
}
