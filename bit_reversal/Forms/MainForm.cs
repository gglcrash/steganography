using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bit_reversal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRev_Click(object sender, EventArgs e)
        {
            (new ReverseForm()).Show();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {

            (new HideForm()).Show();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {

            (new FindForm()).Show();
        }

        private void buttonNoise_Click(object sender, EventArgs e)
        {
            (new NoiseForm()).Show();
        }

        private void buttonAutent_Click(object sender, EventArgs e)
        {
            (new FormAutent()).Show();
        }
    }
}
