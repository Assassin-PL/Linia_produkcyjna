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
    public partial class Ustawienia : Form
    {
        public Ustawienia(Glowny_Program OknoRodzic)
        {
            InitializeComponent();
            this.tableLayoutPanel1.BackgroundImage = OknoRodzic.tableLayoutPanel1.BackgroundImage;
            this.OknoRodzic = OknoRodzic;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ukryj okno dialogowe
            OknoRodzic.Show(); // Pokaż główne okno
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.OknoRodzic.backgroundID = (this.OknoRodzic.backgroundID + 1) % this.OknoRodzic.backgroundList.Count;
            this.tableLayoutPanel1.BackgroundImage = this.OknoRodzic.backgroundList[this.OknoRodzic.backgroundID];
            this.OknoRodzic.tableLayoutPanel1.BackgroundImage = this.OknoRodzic.backgroundList[this.OknoRodzic.backgroundID];
        }
    }
}
