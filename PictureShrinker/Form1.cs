using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // openFileDialog1.ShowDialog();

            OpenFileDialog fileSelectPopUp = new OpenFileDialog();
            fileSelectPopUp.Title = "";
            fileSelectPopUp.InitialDirectory = @"c:\";
            fileSelectPopUp.Filter = "All JPG FILES (*.jpeg*)|*.jpeg*|(*.jpg*)|*.jpg*|(*.bmp*)|*.bmp*|(*.png*)|*.png*|(*.gif*)|*.gif*|All files (*.*)|*.*";
            fileSelectPopUp.FilterIndex = 2;
            fileSelectPopUp.RestoreDirectory = true;
            if (fileSelectPopUp.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fileSelectPopUp.FileName;
                string putanja = textBox1.Text;
                pictureBox1.ImageLocation = putanja;

            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void smanjibutton2_Click(object sender, EventArgs e)
        {

            
                 Image oldImage = Image.FromFile(textBox1.Text);
            Bitmap resized = new Bitmap(oldImage, new Size(oldImage.Width / 4, oldImage.Height / 4));
            string privtext = textBox1.Text;

            privtext = privtext.Replace(".PNG", " ver4x.PNG");
            privtext = privtext.Replace(".png", " ver4x.png");
            privtext = privtext.Replace(".gif", " ver4x.gif");
            privtext = privtext.Replace(".GIF", " ver4x.GIF");
            privtext = privtext.Replace(".BMP", " ver4x.BMP");
            privtext = privtext.Replace(".JPG", " ver4x.JPG");
            privtext = privtext.Replace(".jpg", " ver4x.jpg");
            privtext = privtext.Replace(".JPEG", " ver4x.JPEG");
            privtext = privtext.Replace(".jpeg", " ver4x.jpeg");
           

            MessageBox.Show("nova verzija slike je snimljena pod imenom   " + privtext);

         
           
                resized.Save(privtext, ImageFormat.Jpeg);
                pictureBox1.ImageLocation = privtext;
                textBox2.Text = privtext;
                spremantoolStripStatusLabel1.Text = "Umanjio 4 x";
                uradjenotoolStripProgressBar1.Value = 25;
          
            
           


            //Image oldImage = Image.FromFile(textBox1.Text);
           // Image thumb = new Bitmap(200, 200,
          //  System.Drawing.Imaging.PixelFormat.Format24bppRgb);
           // Graphics oGraphic = Graphics.FromImage(thumb);

         //   oGraphic.CompositingQuality = CompositingQuality.HighSpeed;
          //  oGraphic.SmoothingMode = SmoothingMode.HighSpeed;
           // oGraphic.InterpolationMode = InterpolationMode.Low;

         //   Rectangle rect = new Rectangle(0, 0, 200, 200);
         //   oGraphic.DrawImage(oldImage, rect);
          
          //  thumb.Save(privtext, ImageFormat.Jpeg);

           

            // return 0;


        }

        private void dvaputabutton2_Click(object sender, EventArgs e)
        {
            
            
            Image oldImage = Image.FromFile(textBox1.Text);
            Bitmap resized = new Bitmap(oldImage, new Size(oldImage.Width / 2, oldImage.Height / 2));
            string privtext = textBox1.Text;


            privtext = privtext.Replace(".PNG", " ver2x.PNG");
            privtext = privtext.Replace(".png", " ver2x.png");
            privtext = privtext.Replace(".gif", " ver2x.gif");
            privtext = privtext.Replace(".GIF", " ver2x.GIF");
            privtext = privtext.Replace(".BMP", " ver2x.BMP");
            privtext = privtext.Replace(".JPG", " ver2x.JPG");
            privtext = privtext.Replace(".jpg", " ver2x.jpg");
            privtext = privtext.Replace(".JPEG", " ver2x.JPEG");
            privtext = privtext.Replace(".jpeg", " ver2x.jpeg");
         

            MessageBox.Show("nova verzija slike je snimljena pod imenom   " + privtext);
            resized.Save(privtext, ImageFormat.Jpeg);


            pictureBox1.ImageLocation = privtext;
            textBox2.Text = privtext;
            spremantoolStripStatusLabel1.Text = "Umanjio 2 x";
            uradjenotoolStripProgressBar1.Value = 50;
        }

        private void osamputamanjebutton2_Click(object sender, EventArgs e)
        {
            Image oldImage = Image.FromFile(textBox1.Text);
            Bitmap resized = new Bitmap(oldImage, new Size(oldImage.Width / 8, oldImage.Height / 8));
            string privtext = textBox1.Text;

            privtext = privtext.Replace(".PNG", " ver8x.PNG");
            privtext = privtext.Replace(".png", " ver8x.png");
            privtext = privtext.Replace(".gif", " ver8x.gif");
            privtext = privtext.Replace(".GIF", " ver8x.GIF");
            privtext = privtext.Replace(".BMP", " ver8x.BMP");
            privtext = privtext.Replace(".JPG", " ver8x.JPG");
            privtext = privtext.Replace(".jpg", " ver8x.jpg");
            privtext = privtext.Replace(".JPEG", " ver8x.JPEG");
            privtext = privtext.Replace(".jpeg", " ver8x.jpeg");
     

            MessageBox.Show("nova verzija slike je snimljena pod imenom   " + privtext);
            resized.Save(privtext, ImageFormat.Jpeg);
            pictureBox1.ImageLocation = privtext;
            textBox2.Text = privtext;
            spremantoolStripStatusLabel1.Text = "Umanjio 8 x";
            uradjenotoolStripProgressBar1.Value = 12;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
