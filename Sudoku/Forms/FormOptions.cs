using System;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
        }

        private void FormOpcje_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                FormMenu.mainMenuWindow.Show();
            else if (e.CloseReason != CloseReason.ApplicationExitCall)
                Application.Exit();
        }

        private void buttonTloOkna_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.WindowColor = colorDialog.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void buttonTloPrzyciskow_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.ButtonColor = colorDialog.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void buttonTekstPrzyciskow_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.ButtonTextColor = colorDialog.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void FormOpcje_Load(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.Difficulty)
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
            if (radioButtonLatwa.Checked) Properties.Settings.Default.Difficulty = "Łatwa";
            Properties.Settings.Default.Save();
        }

        private void radioButtonSrednia_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSrednia.Checked) Properties.Settings.Default.Difficulty = "Średnia";
            Properties.Settings.Default.Save();
        }

        private void radioButtonTrudna_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTrudna.Checked) Properties.Settings.Default.Difficulty = "Trudna";
            Properties.Settings.Default.Save();
        }

        private void checkBoxObrazZamiastDruku_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PictureInsteadOfPrint = checkBoxObrazZamiastDruku.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
