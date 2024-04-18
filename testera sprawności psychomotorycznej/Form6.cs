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
    public partial class Response : Form
    {
        public Response()
        {
            InitializeComponent();
        }

        public Response(Monitoring Przeslane_okno)
        {
            InitializeComponent();
            this.timer1.Enabled = true;
            this.timer1.Start();
            this.OknoGl = Przeslane_okno;
            this.OknoGl.timer_diag.Stop();
            this.FormClosed += this.Response_FormClosed;
            this.KeyPress += Response_KeyPress;
            this.tableLayoutPanel1.BackgroundImage = this.OknoGl.tableLayoutPanel1.BackgroundImage;
            Random rand = new Random();

            // Zakres wartości ASCII dla znaków klawiatury
            int minValue = 32; // Pierwszy drukowalny znak (spacja)
            int maxValue = 126; // Ostatni drukowalny znak (tylda)

            // Wylosuj losową liczbę z zakresu ASCII
            int randomAsciiValue = rand.Next(minValue, maxValue + 1);

            // Konwertuj wartość ASCII na znak
            this.randomChar = (char)randomAsciiValue;
            this.label1.Text = this.zawartosc_tekstu_do_wyswietlenia + " " + this.randomChar;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Response_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Kod do wykonania po zamknięciu formularza
            // this.OknoGl.timer_diag.Start();
        }

        private void Response_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == this.randomChar)
            {
                this.timer1.Stop();
                this.OknoGl.timer_diag.Start();
                this.Close();
            }
            else
            {
                this.zamkniecie();
            }
        }

        private void zamkniecie()
        {
            this.timer1.Stop();
            this.OknoGl.Hide();
            this.OknoGl.OknoRodzic1.Czy_zalogowano = false;
            this.OknoGl.OknoRodzic1.Show();
            this.OknoGl.Okno_komunikatow.Close();
            this.OknoGl.timer_diag.Stop();
            this.timer1.Enabled = false;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.zamkniecie();
        }
    }
}
