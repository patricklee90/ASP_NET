using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2_Exam2_Eating_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.SelectedItem);
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("The List is empty");
                Application.Exit();
            }
        }
    }
}
