using SudokuLib.Core;
using SudokuLib.OptionOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class FormGame : Form
    {
        public static FormGame gameWindow;

        internal SudokuCell[,] SudokuTable = new SudokuCell[9, 9];
        private readonly List<int> possibleValues = Enumerable.Range(1, 9).ToList();

        private readonly ISudokuPrinter printer;
        private readonly ISudokuCreator sudokuCreator;
        private readonly IUserPickedSaveLoad userPickedSaveLoad;
        private readonly ISudokuLayoutCreator layoutCreator;

        private int[,] board = new int[9, 9];
        private bool[,] isPredefinedCell = new bool[9, 9];

        public int[,] Board => board;

        public FormGame(ISudokuPrinter printer, ISudokuCreator sudokuCreator, IUserPickedSaveLoad userPickedSaveLoad, ISudokuLayoutCreator layoutCreator, bool createNewGame = true) : this()
        {
            this.printer = printer ?? throw new ArgumentNullException(nameof(printer));
            this.sudokuCreator = sudokuCreator ?? throw new ArgumentNullException(nameof(sudokuCreator));
            this.userPickedSaveLoad = userPickedSaveLoad ?? throw new ArgumentNullException(nameof(userPickedSaveLoad));
            this.layoutCreator = layoutCreator ?? throw new ArgumentNullException(nameof(layoutCreator));
            if (createNewGame)
                (board, isPredefinedCell) = sudokuCreator.PopulateBoardWithNewSudoku(SudokuTable);
            else
                (board, isPredefinedCell) = userPickedSaveLoad.LoadFromUserPickedFile(SudokuTable);
        }

        public FormGame()
        {
            gameWindow = this;
            InitializeComponent();
            layoutCreator.CreateSudokuTable(SudokuTable, tableLayoutPanelBoard);
        }

        private void ButtonSaveState_Click(object sender, EventArgs e)
        {
            userPickedSaveLoad.SaveToUserPickedFile(board, isPredefinedCell);
        }

        private void ButtonLoadState_Click(object sender, EventArgs e)
        {
            (board, isPredefinedCell) = userPickedSaveLoad.LoadFromUserPickedFile(SudokuTable);
        }

        private void TextBoxSudoku_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            TryNavigateToNextCell(sender, e.KeyCode);
        }

        private void TryNavigateToNextCell(object sender, Keys keyCode)
        {
            var pole = (sender as Control).Parent as SudokuCell;
            switch (keyCode)
            {
                case Keys.Left:
                    if (pole.X > 0)
                        pole = SudokuTable[pole.Y, pole.X - 1];
                    break;
                case Keys.Right:
                    if (pole.X < 8)
                        pole = SudokuTable[pole.Y, pole.X + 1];
                    break;
                case Keys.Up:
                    if (pole.Y > 0)
                        pole = SudokuTable[pole.Y - 1, pole.X];
                    break;
                case Keys.Down:
                    if (pole.Y < 8)
                        pole = SudokuTable[pole.Y + 1, pole.X];
                    break;
                default:
                    return;
            }
            pole.textBox.Focus();
        }

        private void ButtonBackToMenu_Click(object sender, EventArgs e)
        {
            FormMenu.mainMenuWindow.Show();
            Close();
        }

        private void ButtonSolve_Click(object sender, EventArgs e)
        {
            Solver solver = new Solver { Orderer = new NoOptionOrderer<int>() };
            var solution = solver.Solve(board);
            ShowSolution(solution);
        }

        private void ShowSolution(int[,] solution)
        {
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    ShowSolutionAtLocation(solution, x, y);
                }
            }
        }

        private void ShowSolutionAtLocation(int[,] solution, int x, int y)
        {
            if (!isPredefinedCell[y, x])
            {
                SudokuTable[y, x].CellValue = solution[y, x];
            }
        }

        private void FormGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                FormMenu.mainMenuWindow.Show();
            else if (e.CloseReason != CloseReason.ApplicationExitCall)
                Application.Exit();
        }

        private void ButtonSupportMe_Click(object sender, EventArgs e)
        {
            int suppportsRemaining = int.Parse(labelRemainingSupports.Text);
            if (suppportsRemaining >= 1)
                if (SupportMe())
                {
                    suppportsRemaining--;
                    labelRemainingSupports.Text = suppportsRemaining.ToString();
                }
        }

        private bool SupportMe()
        {
            foreach (var cell in SudokuTable)
                if (!cell.textBox.Font.Bold)
                {
                    HashSet<int> neigborValues = new HashSet<int>();
                    List<int> options;

                    foreach (var neighbor in cell.neighbors)
                    {
                        var cellValue = SudokuTable[neighbor.Y, neighbor.X].CellValue;
                        if (cellValue != 0)
                            neigborValues.Add(cellValue);
                    }

                    options = new List<int>(possibleValues.Except(neigborValues));
                    if (options.Count == 1)
                    {
                        cell.CellValue = options[0];
                        return true;
                    }
                }
            return false;
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
