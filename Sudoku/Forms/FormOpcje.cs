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
        public FormOpcje()
        {
            InitializeComponent();
        }

        private void FormOpcje_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                FormMenu.glowneOknoMenu.Show();
            else
                Application.Exit();
        }

        private void buttonTloOkna_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.KolorOkna = colorDialog.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void buttonTloPrzyciskow_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.KolorPrzyciskow = colorDialog.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void buttonTekstPrzyciskow_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.KolorTekstuPrzyciskow = colorDialog.Color;
                Properties.Settings.Default.Save();
            }
        }
    }
}
