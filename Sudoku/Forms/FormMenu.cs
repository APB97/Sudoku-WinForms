using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class FormMenu : Form
    {
        public static FormMenu mainMenuWindow;

        public FormMenu()
        {
            InitializeComponent();
            var collection = new PrivateFontCollection();
            collection.AddFontFile(@"Czcionki\VLADIMIR.TTF");
            FontFamily fontFamily = new FontFamily("Vladimir Script", collection);
            labelGameTitle.Font = new Font(fontFamily, 48, FontStyle.Regular);
            mainMenuWindow = this;
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            FormGame game = new FormGame();
            game.Show();
            Hide();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            FormGame loadedGame = new FormGame(false);
            loadedGame.Show();
            Hide();
        }

        private void ButtonOptions_Click(object sender, EventArgs e)
        {
            FormOpcje options = new FormOpcje();
            options.Show();
            Hide();
        }
    }
}
