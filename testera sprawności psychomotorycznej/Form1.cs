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
            this.label2.BackColor = Color.Transparent;
            button1.BackColor = System.Drawing.Color.Green; // Domyślny kolor tła
            PropertyChanged += MainForm_PropertyChanged;
            this.pictureBox1.BackColor = Color.Transparent;
        }

        private void MainForm_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // Sprawdzenie, czy zmieniła się wartość Czy_zalogowano
            if (e.PropertyName == nameof(Czy_zalogowano))
            {
                // Zmiana koloru tła przycisku w zależności od wartości Czy_zalogowano
                if (Czy_zalogowano)
                {
                    button1.BackColor = System.Drawing.Color.Red; // Zmiana koloru tła na czerwony
                }
                else
                {
                    button1.BackColor = System.Drawing.Color.Green; // Zmiana koloru tła na zielony
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.czyZalogowano == true)
            {
                this.Hide();
                this.testy_okno = new Monitoring(this);
                testy_okno.Owner = this;
                this.testy_okno.timer_diag.Start();
                this.testy_okno.ShowDialog();
            }
            else MessageBox.Show("Wprowadzono nieprawidłowe dane.", "Uzytkownik musi byc zalogowany", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.okno_do_logowania = new Login(this);
            okno_do_logowania.Owner = this;
            this.okno_do_logowania.ShowDialog();
        }


    }
}
