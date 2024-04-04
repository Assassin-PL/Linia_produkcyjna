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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);

            // Przypisanie zdarzenia KeyPress dla textBox2
            textBox2.KeyPress += new KeyPressEventHandler(textBox2_KeyPress);
        }

        public Login(Glowny_Program OknoRodzic)
        {
            InitializeComponent();
            this.tableLayoutPanel1.BackgroundImage = OknoRodzic.tableLayoutPanel1.BackgroundImage;
            this.OknoRodzic = OknoRodzic;

            textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);

            // Przypisanie zdarzenia KeyPress dla textBox2
            textBox2.KeyPress += new KeyPressEventHandler(textBox2_KeyPress);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sprawdzenie czy naciśnięto klawisz Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.login = textBox1.Text;
            }
        }

        // Obsługa zdarzenia KeyPress dla textBox2
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sprawdzenie czy naciśnięto klawisz Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.haslo = textBox2.Text;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.haslo) && !string.IsNullOrEmpty(this.login))
            {
                if (
                    this.haslo == Properties.Resources.Prawidlowe_Haslo &&
                    this.login == Properties.Resources.Prawidlowy_Login
                    )
                {
                    if (OknoRodzic != null) OknoRodzic.Czy_zalogowano = !OknoRodzic.Czy_zalogowano;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wprowadzono nieprawidłowe dane.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wprowadzono nieprawidłowe dane.", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
