using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testera_sprawności_psychomotorycznej
{
    public partial class Testy : Form
    {
        public Testy(Glowny_Program OknoRodzic1)
        {
            InitializeComponent();
            this.tableLayoutPanel1.BackgroundImage = OknoRodzic1.tableLayoutPanel1.BackgroundImage;
            this.OknoRodzic1 = OknoRodzic1;
            this.pictureBox1.Image = OknoRodzic1.pictureBox1.Image;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ukryj okno dialogowe
            OknoRodzic1.Show(); // Pokaż główne okno
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
