using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class FormOpcje : Form
    {
        public static Color kolorOkna = SystemColors.Window;
        public static Color kolorPrzyciskow = SystemColors.Window;

        static FormOpcje()
        {
            kolorOkna = Properties.Settings.Default.KolorOkna;
        }

        public FormOpcje()
        {
            InitializeComponent();
            this.BackColor = kolorOkna;
        }

        private void buttonTloOkna_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.KolorOkna = kolorOkna = colorDialog.Color;
                Properties.Settings.Default.Save();
                FormMenu.glowneOknoMenu.BackColor = this.BackColor = kolorOkna;
            }
        }

        private void FormOpcje_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                FormMenu.glowneOknoMenu.Show();
            else
                Application.Exit();
        }

        private void buttonTloPrzyciskow_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.KolorPzyciskow = kolorPrzyciskow = colorDialog.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void buttonTekstPrzyciskow_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.KolorTekstuPrzyciskosw = colorDialog.Color;
                Properties.Settings.Default.Save();
            }
        }
    }
}
