using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class FormMenu : Form
    {
        private readonly ISudokuPrinter printer;
        private readonly ISudokuCreator sudokuCreator;
        private readonly IUserPickedSaveLoad userSaveLoad;
        private readonly ISudokuLayoutCreator layoutCreator;

        public FormMenu(ISudokuPrinter printer, ISudokuCreator sudokuCreator, IUserPickedSaveLoad userSaveLoad, ISudokuLayoutCreator layoutCreator)
        {
            InitializeComponent();
            var collection = new PrivateFontCollection();
            collection.AddFontFile(@"Czcionki\VLADIMIR.TTF");
            FontFamily fontFamily = new FontFamily("Vladimir Script", collection);
            labelGameTitle.Font = new Font(fontFamily, 48, FontStyle.Regular);
            this.printer = printer;
            this.sudokuCreator = sudokuCreator;
            this.userSaveLoad = userSaveLoad;
            this.layoutCreator = layoutCreator;
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            FormGame game = new FormGame(this, printer, sudokuCreator, userSaveLoad, layoutCreator);
            game.Show();
            Hide();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            FormGame loadedGame = new FormGame(this, printer, sudokuCreator, userSaveLoad, layoutCreator, false);
            loadedGame.Show();
            Hide();
        }

        private void ButtonOptions_Click(object sender, EventArgs e)
        {
            FormOptions options = new FormOptions(this);
            options.Show();
            Hide();
        }
    }
}
