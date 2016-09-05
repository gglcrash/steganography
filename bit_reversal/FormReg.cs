using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageHashing;

namespace bit_reversal
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }
        List<Image> imgList = new List<Image>();
        Image tempimg;
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Multiselect = true;
                dlg.Title = "Open Container";
                dlg.Filter = "Images|*.jpg;*.bmp;*.png;*.jpeg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (dlg.FileNames[i] != "")
                        {
                            imgList.Add(Image.FromFile(dlg.FileNames[i]));
                        }
                        else
                        {
                            imgList.Add(Image.FromFile(dlg.FileNames[0]));
                        }
                    }
                    labelResult.ForeColor = Color.Green;
                    labelResult.Text = "Done!";
                }
                else
                {
                    labelResult.ForeColor = Color.Red;
                    labelResult.Text = "Fail!";
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (imgList.Count != 0)
            {
                mysqlClass.DoCommand("insert into man(name,surname,hash0,hash1,hash2,hash3,hash4,hash5,hash6,hash7,hash8,hash9) values('" +
                    textBoxName.Text + "','" + textBoxSurname.Text + "'," +
                    ImageHashing.ImageHashing.AverageHash(imgList[0]) + "," + ImageHashing.ImageHashing.AverageHash(imgList[1]) +
                    "," + ImageHashing.ImageHashing.AverageHash(imgList[2]) + "," + ImageHashing.ImageHashing.AverageHash(imgList[3]) +
                    "," + ImageHashing.ImageHashing.AverageHash(imgList[4]) + "," + ImageHashing.ImageHashing.AverageHash(imgList[5]) +
                    "," + ImageHashing.ImageHashing.AverageHash(imgList[6]) + "," + ImageHashing.ImageHashing.AverageHash(imgList[7]) +
                    "," + ImageHashing.ImageHashing.AverageHash(imgList[8]) + "," + ImageHashing.ImageHashing.AverageHash(imgList[9]) + ")");
            }

            labelResult2.ForeColor = Color.Green;
            labelResult2.Text = "Done!";
            imgList.Clear();
        }

        private void FormReg_Load(object sender, EventArgs e)
        {
            labelResult.Text = "";
            labelResult2.Text = "";
        }
    }
}
