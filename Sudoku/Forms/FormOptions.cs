﻿using System;
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

        private void checkBoxObrazZamiastDruku_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PictureInsteadOfPrint = checkBoxObrazZamiastDruku.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
