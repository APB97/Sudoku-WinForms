using SudokuLib.Core;
using System;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class FormGame : Form, IBoard
    {
        internal SudokuCell[,] SudokuTable = new SudokuCell[9, 9];

        private readonly ISudokuPrinter printer;
        private readonly IUserPickedSaveLoad userPickedSaveLoad;
        private readonly WinFormsSolveBoard winFormsBoardSolver;
        private readonly SudokuSupporter supporter;
        private readonly Form mainForm;

        private int[,] board = new int[9, 9];
        private bool[,] isPredefinedCell = new bool[9, 9];
        private int emptyCells;

        public int[,] Board => board;

        public int EmptyCells
        {
            get => emptyCells;
            set
            {
                emptyCells = value;
                if (value == 0)
                {
                    if (NotUserSolved)
                    {
                        MessageBox.Show("Solved via Solver");
                        BackToMainMenu();

                    }
                    else if (Validator.IsValidBoard(board))
                    {
                        MessageBox.Show("Success");
                        BackToMainMenu();
                    }
                    else
                    {
                        MessageBox.Show("Board is not in a valid state");
                    }
                }
            }
        }

        public bool NotUserSolved { get; set; }

        public FormGame(Form mainForm, ISudokuPrinter printer, ISudokuCreator sudokuCreator, IUserPickedSaveLoad userPickedSaveLoad, ISudokuLayoutCreator layoutCreator, bool createNewGame = true) : this()
        {
            winFormsBoardSolver = new WinFormsSolveBoard();
            supporter = new SudokuSupporter();

            this.mainForm = mainForm ?? throw new ArgumentNullException(nameof(mainForm));
            this.printer = printer ?? throw new ArgumentNullException(nameof(printer));
            this.userPickedSaveLoad = userPickedSaveLoad ?? throw new ArgumentNullException(nameof(userPickedSaveLoad));

            layoutCreator.Board = this;
            layoutCreator?.CreateSudokuTable(SudokuTable, tableLayoutPanelBoard);

            if (sudokuCreator == null) throw new ArgumentNullException(nameof(sudokuCreator));
            if (createNewGame)
                (board, isPredefinedCell) = sudokuCreator.PopulateBoardWithNewSudoku(this, SudokuTable);
            else
                (board, isPredefinedCell, supporter.SuppportsRemaining) = userPickedSaveLoad.LoadFromUserPickedFile(this, SudokuTable);
            
            labelRemainingSupports.Text = supporter.SuppportsRemaining.ToString();
        }

        public FormGame()
        {
            InitializeComponent();
        }

        private void ButtonSaveState_Click(object sender, EventArgs e)
        {
            userPickedSaveLoad.SaveToUserPickedFile(board, isPredefinedCell, supporter);
        }

        private void ButtonLoadState_Click(object sender, EventArgs e)
        {
            (board, isPredefinedCell, supporter.SuppportsRemaining) = userPickedSaveLoad.LoadFromUserPickedFile(this, SudokuTable);
            labelRemainingSupports.Text = supporter.SuppportsRemaining.ToString();
        }

        private void ButtonBackToMenu_Click(object sender, EventArgs e)
        {
            BackToMainMenu();
        }

        private void BackToMainMenu()
        {
            mainForm.Show();
            Close();
        }

        private void ButtonSolve_Click(object sender, EventArgs e)
        {
            winFormsBoardSolver.Solve(this, board, isPredefinedCell, SudokuTable);
        }

        private void FormGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                mainForm.Show();
            else if (e.CloseReason != CloseReason.ApplicationExitCall)
                Application.Exit();
        }

        private void ButtonSupportMe_Click(object sender, EventArgs e)
        {
            supporter.RequestSupport(this, SudokuTable);
            labelRemainingSupports.Text = supporter.SuppportsRemaining.ToString();
        }

        private void ButtonSavePng_Click(object sender, EventArgs e)
        {
            printer.Save(board, isPredefinedCell);
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            printer.Print();
        }
    }
}
