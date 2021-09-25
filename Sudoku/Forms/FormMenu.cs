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
        private readonly ISudokuCreator sudokuCreator;

        public FormMenu(ISudokuPrinter printer, ISudokuCreator sudokuCreator)
        {
            InitializeComponent();
            var collection = new PrivateFontCollection();
            collection.AddFontFile(@"Czcionki\VLADIMIR.TTF");
            FontFamily fontFamily = new FontFamily("Vladimir Script", collection);
            labelGameTitle.Font = new Font(fontFamily, 48, FontStyle.Regular);
            mainMenuWindow = this;
            this.printer = printer;
            this.sudokuCreator = sudokuCreator;
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            FormGame game = new FormGame(printer, sudokuCreator);
            game.Show();
            Hide();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            FormGame loadedGame = new FormGame(printer, sudokuCreator, false);
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
