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
            else if (e.CloseReason != CloseReason.ApplicationExitCall)
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

        private void FormOpcje_Load(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.Trudnosc)
            {
                case "Łatwa":
                    radioButtonLatwa.Checked = true;
                    break;
                case "Średnia":
                    radioButtonSrednia.Checked = true;
                    break;
                case "Trudna":
                    radioButtonTrudna.Checked = true;
                    break;
            }
        }

        private void radioButtonLatwa_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLatwa.Checked) Properties.Settings.Default.Trudnosc = "Łatwa";
            Properties.Settings.Default.Save();
        }

        private void radioButtonSrednia_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSrednia.Checked) Properties.Settings.Default.Trudnosc = "Średnia";
            Properties.Settings.Default.Save();
        }

        private void radioButtonTrudna_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTrudna.Checked) Properties.Settings.Default.Trudnosc = "Trudna";
            Properties.Settings.Default.Save();
        }

        private void checkBoxObrazZamiastDruku_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ObrazZamiastWydruku = checkBoxObrazZamiastDruku.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
