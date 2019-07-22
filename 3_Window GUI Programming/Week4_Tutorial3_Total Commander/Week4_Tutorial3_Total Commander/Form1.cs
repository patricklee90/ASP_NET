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

namespace Week4_Tutorial3_Total_Commander
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string s in Directory.GetFiles(textBox1.Text))
                listBox1.Items.Add(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (string s in Directory.GetFiles(textBox2.Text))
                listBox2.Items.Add(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Move(listBox1.Text, textBox2.Text + "\\" + Path.GetFileName(listBox1.Text));
            RefreshViews();
        }

        private void RefreshViews()
        {
            listBox1.Items.Clear();
            foreach (string s in Directory.GetFiles(textBox1.Text))
                listBox1.Items.Add(s);

            listBox2.Items.Clear();
            foreach (string s in Directory.GetFiles(textBox2.Text))
                listBox2.Items.Add(s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.Move(listBox2.Text, textBox1.Text + "\\" + Path.GetFileName(listBox2.Text));
            RefreshViews();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            File.Copy(listBox1.Text, textBox2.Text + "\\" + Path.GetFileName(listBox1.Text));
            RefreshViews();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.Copy(listBox2.Text, textBox1.Text + "\\" + Path.GetFileName(listBox2.Text));
            RefreshViews();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            File.Delete(listBox1.Text);
            RefreshViews();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            File.Delete(listBox2.Text);
            RefreshViews();
        }
    }
}
