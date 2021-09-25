using Sudoku.Properties;
using SudokuLib.Core;
using SudokuLib.OptionOrder;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class FormGame : Form
    {
        public static FormGame gameWindow;

        internal SudokuCell[,] SudokuTable = new SudokuCell[9, 9];
        private readonly List<int> possibleValues = Enumerable.Range(1, 9).ToList();
        private readonly int[] HorizontalDisplacement = new int[9] { 0, 1, 2, 0, 1, 2, 0, 1, 2 };
        private readonly int[] VerticalDisplacement = new int[9] { 0, 0, 0, 1, 1, 1, 2, 2, 2 };

        private int[,] board = new int[9, 9];
        private bool[,] isPredefinedCell = new bool[9, 9];

        public int[,] Board => board;

        public FormGame(bool createNewGame = true)
        {
            gameWindow = this;
            InitializeComponent();
            CreateSudokuTable();

            if (createNewGame)
                CreateNewGame();
            else
                LoadFromUserPickedFile();
        }

        private void CreateSudokuTable()
        {
            for (int squareId = 0; squareId < 9; ++squareId)
            {
                Control[] foundTableLayoutMatches = tableLayoutPanelPlansza.Controls.Find("tableLayoutPanel" + squareId, false);
                PopulateSquareIfIsTableLayoutPanel(foundTableLayoutMatches, squareId);
            }
        }

        private void PopulateSquareIfIsTableLayoutPanel(Control[] foundTableLayoutMatches, int squareId)
        {
            if (foundTableLayoutMatches.FirstOrDefault() is TableLayoutPanel currentSquare)
            {
                currentSquare.TabIndex = squareId;
                InitAllCellsInSquare(currentSquare, squareId);
            }
        }

        private void InitAllCellsInSquare(TableLayoutPanel currentSquare, int squareId)
        {
            for (int cellNumberInSquare = 0; cellNumberInSquare < 9; ++cellNumberInSquare)
            {
                InitSudokuCellInSquare(currentSquare, squareId, cellNumberInSquare);
            }
        }

        private void InitSudokuCellInSquare(TableLayoutPanel currentSquare, int squareId, int cellNumberInSquare)
        {
            var pole = new SudokuCell(HorizontalDisplacement[cellNumberInSquare] + HorizontalDisplacement[squareId] * 3, VerticalDisplacement[cellNumberInSquare] + VerticalDisplacement[squareId] * 3);
            currentSquare.Controls.Add(pole);
            SudokuTable[VerticalDisplacement[cellNumberInSquare] + VerticalDisplacement[squareId] * 3,
                HorizontalDisplacement[cellNumberInSquare] + HorizontalDisplacement[squareId] * 3] = pole;
            pole.textBox.PreviewKeyDown += TextBoxSudoku_PreviewKeyDown;
            pole.textBox.ForeColor = Color.DimGray;
        }

        private void CreateNewGame()
        {
            int[,] emptyBoard = new int[9, 9];
            Solver solver = new Solver() { Orderer = new OptionRandomizedOrderer<int>() };
            int[,] solvedBoard = solver.Solve(emptyBoard);
            board = SudokuBlanker.MakeBlanks(solvedBoard, Settings.Default.DesiredBlanks);
            UpdateAllVisualCells();
            MessageBox.Show(Validator.IsValidBoard(board) ? "Board OK" : "Board NOT OK");
        }

        private void UpdateAllVisualCells()
        {
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    InitializeCellStateIfPredifinedAtLocation(x, y);
                }
            }
        }

        private void InitializeCellStateIfPredifinedAtLocation(int x, int y)
        {
            isPredefinedCell[y, x] = board[y, x] != 0;
            if (isPredefinedCell[y, x])
            {
                SudokuTable[y, x].InitAsPredefined(board[y, x]);
            }
        }

        private void ButtonSaveState_Click(object sender, EventArgs e)
        {
            SaveToUserPickedFile();
        }

        private void SaveToUserPickedFile()
        {
            if (saveSudokuDialog.ShowDialog() == DialogResult.OK)
            {
                SudokuSaveLoad.Save(saveSudokuDialog.FileName, board, isPredefinedCell);
            }
        }

        private void ButtonLoadState_Click(object sender, EventArgs e)
        {
            LoadFromUserPickedFile();
        }

        private void LoadFromUserPickedFile()
        {
            if (openSudokuDialog.ShowDialog() == DialogResult.OK)
            {
                (board, isPredefinedCell) = SudokuSaveLoad.Load(openSudokuDialog.FileName);
                LoadAllCellStates();
            }
        }

        private void LoadAllCellStates()
        {
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    InitializeCellStateToLoadedValue(x, y);
                }
            }
        }

        private void InitializeCellStateToLoadedValue(int x, int y)
        {
            if (isPredefinedCell[y, x])
            {
                SudokuTable[y, x].InitAsPredefined(board[y, x]);
            }
            else
            {
                SudokuTable[y, x].CellValue = board[y, x];
            }
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
            var painter = new Painter() 
            {
                CellSize = Settings.Default.PrintedCellSize, 
                FontSize = Settings.Default.PrintedFontSize,
                LineWidth = Settings.Default.PrintedLineWidth
            };
            var img = painter.CreateImage(board, isPredefinedCell);
            img.Save("last.png", System.Drawing.Imaging.ImageFormat.Png);
            Process openFileProcess = new Process();
            openFileProcess.StartInfo.FileName = "last.png";
            openFileProcess.StartInfo.Verb = "Open";
            openFileProcess.Start();
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            if (File.Exists("last.png"))
            {
                Process printProcess = new Process();
                printProcess.StartInfo.FileName = "last.png";
                printProcess.StartInfo.Verb = "Print";
                printProcess.Start();
            }
        }
    }
}
