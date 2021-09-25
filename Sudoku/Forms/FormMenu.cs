using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class FormMenu : Form
    {
        public static FormMenu mainMenuWindow;
        public PrivateFontCollection collection;

        public FormMenu()
        {
            InitializeComponent();
            collection = new PrivateFontCollection();
            collection.AddFontFile(@"Czcionki\VLADIMIR.TTF");
            FontFamily fontFamily = new FontFamily("Vladimir Script", collection);
            labelGameTitle.Font = new Font(fontFamily, 48, FontStyle.Regular);
            mainMenuWindow = this;
        }

        private void buttonGraj_Click(object sender, EventArgs e)
        {
            FormGame gra = new FormGame();
            gra.Show();
            this.Hide();
        }

        private void buttonWyjscie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonWczytaj_Click(object sender, EventArgs e)
        {
            FormGame wczytanaGra = new FormGame(false);
            wczytanaGra.Show();
            this.Hide();
        }

        private void buttonOpcje_Click(object sender, EventArgs e)
        {
            FormOpcje opcje = new FormOpcje();
            opcje.Show();
            this.Hide();
        }
    }
}
