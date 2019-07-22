using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3_Tutorial2_Brush_and_Text_Output
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ResizeRedraw = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Brush
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);

            // require to display image
            Bitmap photoBitmap = new Bitmap(@"D:\Window GUI Programming\Week3_Tutorial2_Brush and Text Output\Week3_Tutorial2_Brush and Text Output\MyPhoto.jpg");

            // Current Font Size
            Font myFavorFont = new Font("Red", 13, FontStyle.Bold);

            // Current Window Size
            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;

            // change window color into black
            g.FillRectangle(blackBrush, 0, 0, width, height);

            int imageWidth = photoBitmap.Width;
            int imageHeight = photoBitmap.Height;

            // resize image, follow ratio display at the window center.
            // Image display top left of the window
            double ratio = Math.Min((double)this.Height / imageHeight,
                (double)this.Width / imageWidth);
            int x = (int)(this.Width - imageWidth * ratio) / 2;
            int y = (int)(this.Height - imageHeight * ratio) / 2;
            Rectangle formRect = new Rectangle(x, y, (int)(imageWidth * ratio),
               (int)(imageHeight * ratio));
            Rectangle imageRect = new Rectangle(0, 0, imageWidth, imageHeight);

            // Display Image
            g.DrawImage(photoBitmap, formRect, imageRect, GraphicsUnit.Pixel);
            // Output Text
            g.DrawString("string...", myFavorFont, whiteBrush, x + 20, y + formRect.Height - 100);

        }
    }
}
