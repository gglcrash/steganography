using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bit_reversal
{
    public partial class HideForm : Form
    {
        public HideForm()
        {
            InitializeComponent();
        }

        private LockBitmap containerBitmap;
        private LockBitmap imageBitmap;
        private Bitmap container;
        private Bitmap img;
        private bool containerAdded, imageAdded;

        private void openContainerButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Container";
                dlg.Filter = "Images|*.jpg;*.bmp;*.png;*.jpeg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    container = (Bitmap)Image.FromFile(dlg.FileName);
                    Image tempimg = Image.FromFile(dlg.FileName);
                    originalPictureBox.Image = tempimg;
                    containerAdded = true;
                    containerBitmap = new LockBitmap(container);
                    

                }
            }

            if (containerAdded && imageAdded)
            {
                hideButton.Enabled = true;
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


        private void openImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Container";
                dlg.Filter = "Images|*.jpg;*.bmp;*.png;*.jpeg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    img = (Bitmap)Image.FromFile(dlg.FileName);
                    Image tempimg = Image.FromFile(dlg.FileName);
                    imagePictureBox.Image = tempimg;
                    imageAdded = true;
                    imageBitmap = new LockBitmap(img);

                }
            }
            if (containerAdded && imageAdded)
            {
                hideButton.Enabled = true;
            }
        }

        private string imageStr = "";

        private void hideButton_Click(object sender, EventArgs e)
        {
            saveButton.Enabled = true;

            /*   Console.WriteLine(Convert.ToString(15, 2));
            Console.WriteLine(Convert.ToInt32("1011", 2));*/

            imageBitmap.LockBits();
            Color tmpColor;


            int count = 0; //сколько пикселей контейнера изменено после того, как был взят 1 пиксель изображения (для перехода дальше нужно 4)
            int posVal = 0; //позиция в строке из 32 символов, содержащей информацию о цвете 1 пикселя изображения
            int visits = 0; //сколько пикселей изображения просмотрено (когда переходить на следующую строку)
            int row = 0; //номер строки изображения (++ после получения 256 предыдущих пикселей)
            string tempA = "";
            string tempR = "";
            string tempG = "";
            string tempB = "";
            byte A, R, G, B;
            char[] arr = new char[8];
            containerBitmap.LockBits();
            for (int i = 0; i < 512; i ++)
            {
                for (int j = 0; j < 512; j ++)
                {

                    if (count == 0)
                    {
                        if (row == 256)
                        {
                            row = 0;
                        }
                        tmpColor = imageBitmap.GetPixel(row, visits);
                        imageStr += setBitsString(Convert.ToString(tmpColor.A, 2));
                        imageStr += setBitsString(Convert.ToString(tmpColor.R, 2));
                        imageStr += setBitsString(Convert.ToString(tmpColor.G, 2));
                        imageStr += setBitsString(Convert.ToString(tmpColor.B, 2));

                        if (visits == 255)
                        {
                            row++;
                            visits = 0;
                        }
                        else
                        {
                            visits++;
                        }
                    }

                    if (count < 4)
                    {
                        tmpColor = containerBitmap.GetPixel(i, j);
                        tempA = setBitsString(Convert.ToString(tmpColor.A, 2));
                        for (int k = 0; k < 6; k++)
                        {
                            arr[k] = tempA[k];
                        }
                        arr[6] = imageStr[posVal++];
                        arr[7] = imageStr[posVal++];
                        tempA = new string(arr);
                        A = Convert.ToByte(tempA, 2);

                        tempR = setBitsString(Convert.ToString(tmpColor.R, 2));
                        for (int k = 0; k < 6; k++)
                        {
                            arr[k] = tempR[k];
                        }
                        arr[6] = imageStr[posVal++];
                        arr[7] = imageStr[posVal++];
                        tempR = new string(arr);
                        R = Convert.ToByte(tempR, 2);

                        tempG = setBitsString(Convert.ToString(tmpColor.G, 2));
                        for (int k = 0; k < 6; k++)
                        {
                            arr[k] = tempG[k];
                        }
                        arr[6] = imageStr[posVal++];
                        arr[7] = imageStr[posVal++];
                        tempG = new string(arr);
                        G = Convert.ToByte(tempG, 2);

                        tempB = setBitsString(Convert.ToString(tmpColor.B, 2));
                        for (int k = 0; k < 6; k++)
                        {
                            arr[k] = tempB[k];
                        }
                        arr[6] = imageStr[posVal++];
                        arr[7] = imageStr[posVal++];
                        tempB = new string(arr);
                        B = Convert.ToByte(tempB, 2);


                        containerBitmap.SetPixel(i, j, Color.FromArgb(A, R, G, B));

                        if (count == 3)
                        {
                            count = 0;
                            posVal = 0;
                            imageStr = "";
                        }
                        else
                        {
                            count++;
                        }
                    }
                    
                }
            }
            imageBitmap.UnlockBits();
            containerBitmap.UnlockBits();


            

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            containerBitmap.source.Save("C:\\Users\\gglcrash\\Desktop\\Курсач\\fullCont.png", System.Drawing.Imaging.ImageFormat.Png);
        }


    }
}

