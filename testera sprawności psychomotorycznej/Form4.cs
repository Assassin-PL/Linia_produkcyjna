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
    public partial class OknoInfo : Form
    {
        public OknoInfo()
        {
            InitializeComponent();
        }

        public OknoInfo(Testy OknGl, String TekstInfo)
        {
            InitializeComponent();
            OknoGl = OknGl;
            this.label1.Text = TekstInfo;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
