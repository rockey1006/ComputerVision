using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "c:\\images";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(ofd.FileName);
                picOrig.Image = bmp;

            }
        }

        private void btnConvertToGrey_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(picOrig.Image);
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color cp = bmp.GetPixel(i, j);
                    int greyVal = (int)(0.299 * cp.R + 0.587 * cp.G + 0.114 * cp.B);
                    bmp.SetPixel(i, j, Color.FromArgb(greyVal, greyVal, greyVal));
                }
            picProcessed.Image = bmp;
        }

        private void btnAdjustBrightness_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(picOrig.Image);
            int brightness = 30; // increase brightness by 30
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color cp = bmp.GetPixel(i, j);
                    int newR = cp.R + brightness;
                    if (newR > 255)
                        newR = 255;
                    if (newR < 0)
                        newR = 0;
                    int newG = cp.G + brightness;
                    if (newG > 255)
                        newG = 255;
                    if (newG < 0)
                        newG = 0;
                    int newB = cp.B + brightness;
                    if (newB > 255)
                        newB = 255;
                    if (newB < 0)
                        newB = 0;
                    bmp.SetPixel(i, j, Color.FromArgb(newR, newG, newB));
                }
            picProcessed.Image = bmp;
        }

        private void btnAdjustContrast_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(picOrig.Image);
            int T = 20;
            double C = ((100 + T) / 100.0) * ((100 + T) / 100.0); // calculated contrast
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color cp = bmp.GetPixel(i, j);
                    int B = (int)(((((cp.B / 255.0) - 0.5) * C) + 0.5) * 255.0);
                    int R = (int)(((((cp.R / 255.0) - 0.5) * C) + 0.5) * 255.0);
                    int G = (int)(((((cp.G / 255.0) - 0.5) * C) + 0.5) * 255.0);
                    if (B > 255)
                        B = 255;
                    if (B < 0)
                        B = 0;
                    if (R > 255)
                        R = 255;
                    if (R < 0)
                        R = 0;
                    if (G > 255)
                        G = 255;
                    if (G < 0)
                        G = 0;
                    bmp.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            picProcessed.Image = bmp;
        }

        private void btnSaveProcessedPicture_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = "d:\\images";
            sfd.Filter = "jpeg|*.jpg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(picProcessed.Image);
                bmp.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                // save as jpeg
            }
        }
    }
}
