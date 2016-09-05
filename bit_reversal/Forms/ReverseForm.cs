using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bit_reversal
{
    public partial class ReverseForm : Form
    {
        public ReverseForm()
        {
            InitializeComponent();
        }


        uint Reverse(uint x)
        {

            x = (((x & 0xaaaaaaaa) >> 1) | ((x & 0x55555555) << 1));
            x = (((x & 0xcccccccc) >> 2) | ((x & 0x33333333) << 2));
            x = (((x & 0xf0f0f0f0) >> 4) | ((x & 0x0f0f0f0f) << 4));
            x = (((x & 0xff00ff00) >> 8) | ((x & 0x00ff00ff) << 8));
            return (((x >> 16) | (x << 16)));
        }

        private Bitmap originalBitmap;
        private Bitmap reversedBitmap;
        private void openButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Images|*.jpg;*.bmp;*.png;*.jpeg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(dlg.FileName);
          //          Image img2 = Image.FromFile(dlg.FileName);
                    originalBitmap = (Bitmap)img;
            //        reversedBitmap = (Bitmap)img2;
                    reversedBitmap = new Bitmap(256,256);                      // SIZE OF BITMAP
                    originalPictureBox.Image = img;
                }
            }
            imageRevButton.Enabled = true;
        }

        private void imageRevButton_Click(object sender, EventArgs e)
        {
            for (int col = 0; col < 256/*originalBitmap.Height*/; col++)
            {
                for (int row = 0; row < 256/*originalBitmap.Width*/; row++)
                {
                    int rowRev = (int)(Reverse((uint)row) >> 24);
                    int colRev = (int)(Reverse((uint)col) >> 24);
          //          int y = originalBitmap.GetPixel(col, row).R;
                    reversedBitmap.SetPixel(colRev, rowRev, originalBitmap.GetPixel(col, row));
                }
            }

            reversedPictureBox.Image = reversedBitmap;
            reversedPictureBox.Refresh();
            saveButton.Enabled = true;
        }
        int savedCount = 0;
        private void saveButton_Click(object sender, EventArgs e)
        {
            reversedBitmap.Save("C:\\Users\\gglcrash\\Desktop\\Курсач\\tempimg.png", System.Drawing.Imaging.ImageFormat.Png);

            if (savedCount > 0)
            {
                reversedBitmap.Save("C:\\Users\\gglcrash\\Desktop\\Курсач\\tempimg2.png", System.Drawing.Imaging.ImageFormat.Png);
            }
            savedCount++;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hideImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideForm hideForm = new HideForm();
            hideForm.Show();
        }

        private void getHiddenImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindForm findForm = new FindForm();
            findForm.Show();
        }

        private void removeNoiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoiseForm noiseForm = new NoiseForm();
            noiseForm.Show();
        }
    }
}
