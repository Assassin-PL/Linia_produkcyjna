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
    public partial class Event_Form : Form
    {
        public Event_Form()
        {
            InitializeComponent();
        }

        public Event_Form(Monitoring OknoGlowne)
        {
            InitializeComponent();
            this.OknoGlowne = OknoGlowne;
            this.tableLayoutPanel1.BackgroundImage = OknoGlowne.tableLayoutPanel1.BackgroundImage;
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
            this.label3.BackColor = Color.Transparent;
            this.label4.BackColor = Color.Transparent;
            this.pictureBox1.Image = Properties.Resources.silin_caly;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.BackColor = Color.Transparent;
            this.pictureBox2.Image = Properties.Resources.zawory_caly;
            this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox2.BackColor = Color.Transparent;
            this.pictureBox3.Image = Properties.Resources.bez_ognia;
            this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox3.BackColor = Color.Transparent;
            this.pictureBox4.Image = Properties.Resources.hala;
            this.pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox4.BackColor = Color.Transparent;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
