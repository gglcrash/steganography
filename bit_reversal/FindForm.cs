using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bit_reversal
{
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();
        }

        private LockBitmap containerBitmap;
        private LockBitmap imageBitmap = new LockBitmap(new Bitmap(256,256));
        
        private bool containerAdded, imageAdded;
        private string imageStr = "";
        private Image container;

        private void openButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Container";
                dlg.Filter = "Images|*.jpg;*.bmp;*.png;*.jpeg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    container = Image.FromFile(dlg.FileName);
                    Image tempimg = Image.FromFile(dlg.FileName);
                    originalPictureBox.Image = tempimg;
                    containerAdded = true;
                    containerBitmap = new LockBitmap((Bitmap) container);
                    
                }
            }
        }


        private string setBitsString(string str)
        {
            int startStrLength = str.Length;
            for (int i = 0; i < 8 - startStrLength; i++)
            {
                str = "0" + str;
            }
            return str;
        }


        private void hideButton_Click(object sender, EventArgs e)
        {
            saveButton.Enabled = true;

            Color tempColor;
            
            string tempA = "";
            string tempR = "";
            string tempG = "";
            string tempB = "";
            byte A, R, G, B;
            containerBitmap.LockBits();
           
            imageBitmap.LockBits();
            char[] arr = new char[8];

            int count = 0; //сколько пикселей контейнера просмотрено (для получения целого пикселя изображения нужно просмотреть 4 пикселя контейнера)
            int visits = 0; //сколько пикселей изображения восстановили (после каждых 256 строка ++)
            int row = 0; //номер строки (++ после 256 предыдущих пикселей)

            for (int i = 0; i < 512; i++)
            {
                for (int j = 0; j < 512; j++)
                {
                    tempColor = containerBitmap.GetPixel(i, j);
                    tempA = setBitsString(Convert.ToString(tempColor.A, 2));
                    imageStr += tempA[6];
                    imageStr += tempA[7];

                    tempR = setBitsString(Convert.ToString(tempColor.R, 2));
                    imageStr += tempR[6];
                    imageStr += tempR[7];

                    tempG = setBitsString(Convert.ToString(tempColor.G, 2));
                    imageStr += tempG[6];
                    imageStr += tempG[7];

                    tempB = setBitsString(Convert.ToString(tempColor.B, 2));
                    imageStr += tempB[6];
                    imageStr += tempB[7];

                    if (count == 3)
                    {
                        
                        for (int k = 0; k < 8; k++)
                        {
                            arr[k] = imageStr[k];
                        }
                        A = Convert.ToByte(new string(arr), 2);

                        for (int k = 0; k < 8; k++)
                        {
                            arr[k] = imageStr[k+8];
                        }
                        R = Convert.ToByte(new string(arr), 2);

                        for (int k = 0; k < 8; k++)
                        {
                            arr[k] = imageStr[k + 16];
                        }
                        G = Convert.ToByte(new string(arr), 2);

                        for (int k = 0; k < 8; k++)
                        {
                            arr[k] = imageStr[k + 24];
                        }
                        B = Convert.ToByte(new string(arr), 2);

                        
                        imageBitmap.SetPixel(row, visits, Color.FromArgb(A, R, G, B));
                        if (visits == 255)
                        {
                            row++;
                            visits = 0;
                        }
                        else
                        {
                            visits++;
                        }

                        count = 0;
                        imageStr = "";
                        
                    }
                    else
                    {
                        count++;
                    }

                }
                

            }
            imageBitmap.UnlockBits();

            containerBitmap.UnlockBits();

            reversedPictureBox.Image = imageBitmap.source;
            reversedPictureBox.Refresh();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            imageBitmap.source.Save("C:\\Users\\gglcrash\\Desktop\\Курсач\\finalimg.png", System.Drawing.Imaging.ImageFormat.Png);
        }

    }
}
