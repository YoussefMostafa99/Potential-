using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace CSharp_Test
{
    public partial class Form1 : Form
    {
        public long Level;
        public Form1()
        {            
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }
        public bool btn2Clicked = false; // check if compress button was NOT clicked

        public void btn2_Click(object sender, EventArgs e) // Compress Button
        {
            string message1 = "Please Choose an Image First Before You Continue";
            string title1 = "Error!";
            if (pB1.Image == null)
            {

                DialogResult result = MessageBox.Show(message1, title1);
            }
            else
            {
                btn2Clicked = true;    // Button was Clicked Save Button Can now be used to save
                QualityLevel();

            }
        }

        public void btn1_Click_1(object sender, EventArgs e) // Load Image Button
        {
            OpenFileDialog fbd = new OpenFileDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                pB1.ImageLocation = fbd.FileName;
            }
        }

      
        public void QualityLevel()
        {
            
            // Get a bitmap.
            Bitmap bmp1 = new Bitmap(pB1.Image);
            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

            // Create an Encoder object based on the GUID
            // for the Quality parameter category.
            System.Drawing.Imaging.Encoder myEncoder =
                System.Drawing.Imaging.Encoder.Quality;

            // Create an EncoderParameters object.
            // An EncoderParameters object has an array of EncoderParameter
            // objects. In this case, there is only one
            // EncoderParameter object in the array.
            EncoderParameters myEncoderParameters = new EncoderParameters(1);

            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, Level);
            myEncoderParameters.Param[0] = myEncoderParameter;
            bmp1.Save(@"D:\TestPhotoQuality.jpg", jpgEncoder, myEncoderParameters);
            MessageBox.Show("Done!","Process");
        }
        public ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }

            return null;
        }

        public void rbtn1_CheckedChanged(object sender, EventArgs e)
        {
            Level = 50L;
        }

        public void rbtn2_CheckedChanged(object sender, EventArgs e)
        {
            Level = 100L;
        }

        public void rbtn4_CheckedChanged(object sender, EventArgs e)
        {
            Level = 75L;
        }

        public void rbtn3_CheckedChanged(object sender, EventArgs e)
        {
            Level = 25L;
        }

        public void rbtn5_CheckedChanged(object sender, EventArgs e)
        {
            Level = 0L;
        }
    }
}