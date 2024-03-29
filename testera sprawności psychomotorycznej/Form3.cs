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
    public partial class Monitoring : Form
    {
        public Monitoring(Glowny_Program OknoRodzic1)
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

        private void Przycisk_MouseHover(object sender, EventArgs e)
        {
            Button przycisk_X = (Button)sender;
            Point PolozeniePrzycisku = przycisk_X.Location;
            Point PolozenieOknaHelp;
            PolozenieOknaHelp = this.Location;
            PolozenieOknaHelp.X += PolozeniePrzycisku.X + 60;
            PolozenieOknaHelp.Y += PolozeniePrzycisku.Y + 100;
            switch (przycisk_X.Text)
            {
                case "1": KolorTla_1 = przycisk_X.BackColor; break;
                case "2": KolorTla_2 = przycisk_X.BackColor; break;
                case "3": KolorTla_3 = przycisk_X.BackColor; break;
            }
            przycisk_X.BackColor = Color.Green;
            string tekst = " cos tu nie gra";
            // this.label2.Text = "Informacja dla przycisku nr " + przycisk_X.Text;
            if (przycisk_X.Text == "Test 1")
            {
                tekst = " Testy reakcji: \n";
            } else if (przycisk_X.Text == "Test 2")
            {
                tekst = " Testy percepcji: \n";
            }
            else if (przycisk_X.Text == "Test 3")
            {
                tekst = " Testy koordynacji ręka-oko: \n";
            }
            else if (przycisk_X.Text == "Test 4")
            {
                tekst = " Testy wytrzymałości: \n";
            }
            else if (przycisk_X.Text == "Test 5")
            {
                tekst = " Testy radzenia sobie w sytuacjach kryzysowych: \n";
            }
            else if (przycisk_X.Text == "Test 6")
            {
                tekst = " Testy oceny ryzyka: \n";
            }
            OknoHelp = new OknoInfo(this, "Informacja dla przycisku nr " + przycisk_X.Text + " \n" + tekst);
            OknoHelp.Show();
            OknoHelp.Location = PolozenieOknaHelp;
        }

        private void Przycisk_MouseLeave(object sender, EventArgs e)
        {
            Button przycisk_X = (Button)sender;
            switch (przycisk_X.Text)
            {
                case "1": przycisk_X.BackColor = KolorTla_1; break;
                case "2": przycisk_X.BackColor = KolorTla_2; break;
                case "3": przycisk_X.BackColor = KolorTla_3; break;
            }
            // this.label2.Text = "";
            if (OknoHelp != null) OknoHelp.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
