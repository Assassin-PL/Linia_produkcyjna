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

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
