using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2_Tutorial5_Keyboard_Event_Response
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string eventMsg;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            eventMsg += "KeyDown: \n" +

            "Alt: " + (e.Alt ? "Yes" : "NO") + '\n' +

            "Shift: " + (e.Shift ? "YES" : "NO") + '\n' +

            "Ctrl: " + (e.Control ? "Yes" : "NO") + '\n' +

            "KeyCode: " + e.KeyCode + '\n' +

            "Keydata: " + e.KeyData + '\n' +

            "KeyValue: " + e.KeyValue + "\n\n";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            eventMsg += "KeyPress: \n" + e.KeyChar + "\n\n";
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            eventMsg += "KeyUp: \n\n";

            MessageBox.Show(eventMsg);

            eventMsg = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
