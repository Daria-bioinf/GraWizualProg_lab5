using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraWizualProg_lab5
{
    public partial class FormUstawienia : Form
    {
        public FormUstawienia()
        {
            InitializeComponent();
        }

        private void butnZapisz_Click(object sender, EventArgs e)
        {
            GameSettings.Rows = (int)numericX.Value;
            GameSettings.Cols = (int)numericY.Value;
            GameSettings.Time = (int)numericCzas.Value;

            GameSettings.Dydelfs = (int)numericDydelfy.Value;
            GameSettings.Krokodyle = (int)numericKrokodyle.Value;
            GameSettings.Szops = (int)numericSzops.Value;

            this.Close();
        }
    }
}
