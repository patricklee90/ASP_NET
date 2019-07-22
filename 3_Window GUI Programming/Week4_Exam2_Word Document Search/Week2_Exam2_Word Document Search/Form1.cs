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

namespace Week2_Exam2_Word_Document_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string s in Directory.GetLogicalDrives())
            {
                comboBox1.Items.Add(s);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string s in Directory.GetDirectories(comboBox1.Text))
            {
                listBox1.Items.Add(s);
            }

            listBox2.Items.Clear();
            foreach (string s in Directory.GetFiles(comboBox1.Text))
            {
                if((Path.GetExtension(s)==".doc")|| (Path.GetExtension(s) == ".docx"))
                    listBox2.Items.Add(s);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string dir = listBox1.Text;
            listBox1.Items.Clear();
            foreach (string s in Directory.GetDirectories(dir))
            {
                listBox1.Items.Add(s);
            }

            listBox2.Items.Clear();
            foreach (string s in Directory.GetFiles(dir))
            {
                if ((Path.GetExtension(s) == ".doc") || (Path.GetExtension(s) == ".docx"))
                    listBox2.Items.Add(s);
            }
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(listBox2.Text);

        }
    }
}
