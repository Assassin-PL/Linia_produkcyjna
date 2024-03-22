using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace testera_sprawności_psychomotorycznej
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.pictureBox1.Image = Properties.Resources.janusz;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex + 1) % imagesList.Count;

            // Wczytaj następny obraz do PictureBox
            this.pictureBox1.Image = imagesList[currentImageIndex];
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(Properties.Resources.url);
        }
    }
}
