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
    public partial class FormAutent : Form
    {
        public FormAutent()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            tempHash = ImageHashing.ImageHashing.AverageHash(pictureBox1.Image);
            resultID = 0;
            List<List<ulong>> bigHashList = new List<List<ulong>>();
            for (int i = 0; i < 10; i++)
            {
                bigHashList.Add(mysqlClass.GetAllHash(i));
            }
            List<int> IDList = mysqlClass.GetAllID();
            for (int i = 0; i < bigHashList.Count; i++)
            {
                for (int j = 0; j < IDList.Count; j++)
                {
                    if ((100 - ImageHashing.ImageHashing.Similarity(tempHash, bigHashList[i][j])) < 4)
                    {
                        resultID = IDList[j];
                        break;
                    }
                }
            }
            if (resultID == 0)
            {
                labelResult.Text = "Matches not\n     found!";
                labelID.Text = "";
                labelName.Text = "";
                labelSurname.Text = "";
            }
            else
            {
                labelResult.Text = "Done!";
                labelID.Text = resultID.ToString();
                labelName.Text = mysqlClass.GetData("select name from man where id_man = " + resultID);
                labelSurname.Text = mysqlClass.GetData("select surname from man where id_man = " + resultID);
            }

        }
        int resultID = 0;
        Image tempimg;
        ulong tempHash;
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Container";
                dlg.Filter = "Images|*.jpg;*.bmp;*.png;*.jpeg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    tempimg = Image.FromFile(dlg.FileName);
                    pictureBox1.Image = tempimg;


                }
            }
        }

        private void FormFind_Load(object sender, EventArgs e)
        {

            pictureBox1.Image = new Bitmap(256, 256);
            labelResult.Text = "";
            labelID.Text = "";
            labelName.Text = "";
            labelSurname.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = new Bitmap(256, 256);
            labelResult.Text = "";
            labelID.Text = "";
            labelName.Text = "";
            labelSurname.Text = "";
        }

        private void linkLabelReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new FormReg()).Show();
        }
    }
}
