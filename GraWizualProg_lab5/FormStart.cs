using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraWizualProg_lab5
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            FormGame game = new FormGame(
                GameSettings.Rows,
                GameSettings.Cols,
                GameSettings.Time,
                GameSettings.Dydelfs,
                GameSettings.Krokodyle,
                GameSettings.Szops
    );

            game.Show();
            this.Hide();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormUstawienia settings = new FormUstawienia();
            settings.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
