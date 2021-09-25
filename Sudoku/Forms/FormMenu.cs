using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class FormMenu : Form
    {
        public static FormMenu mainMenuWindow;
        private readonly ISudokuPrinter printer;

        public FormMenu(ISudokuPrinter printer)
        {
            InitializeComponent();
            var collection = new PrivateFontCollection();
            collection.AddFontFile(@"Czcionki\VLADIMIR.TTF");
            FontFamily fontFamily = new FontFamily("Vladimir Script", collection);
            labelGameTitle.Font = new Font(fontFamily, 48, FontStyle.Regular);
            mainMenuWindow = this;
            this.printer = printer;
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            FormGame game = new FormGame(printer);
            game.Show();
            Hide();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            FormGame loadedGame = new FormGame(printer, false);
            loadedGame.Show();
            Hide();
        }

        private void ButtonOptions_Click(object sender, EventArgs e)
        {
            FormOptions options = new FormOptions();
            options.Show();
            Hide();
        }
    }
}
