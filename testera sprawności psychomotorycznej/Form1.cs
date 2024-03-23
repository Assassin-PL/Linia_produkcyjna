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
    public partial class Glowny_Program : Form
    {

        public Glowny_Program()
        {
            InitializeComponent();
            this.pictureBox1.Image = Properties.Resources.janusz;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.tableLayoutPanel1.BackgroundImage = backgroundList[backgroundID];
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
            // this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ustawienia_okno = new Ustawienia(this);
            // Ustawienie bieżącego formularza jako właściciela dla nowego formularza
            ustawienia_okno.Owner = this;
            this.ustawienia_okno.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(Properties.Resources.url);
        }
    }
}
