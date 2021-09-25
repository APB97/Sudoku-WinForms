using SudokuLib.Core;
using SudokuLib.OptionOrder;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        private bool[,] isPredifinedCell = new bool[9, 9];

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
            int[,] emptyBoard = new int[9,9];
            Solver solver = new Solver() { Orderer = new OptionRandomizedOrderer<int>() };
            int[,] solvedBoard = solver.Solve(emptyBoard);
            int[,] blankedBoard = SudokuBlanker.MakeBlanks(solvedBoard, 35);
            board = blankedBoard;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    bool notEmptied = blankedBoard[i, j] != 0;
                    isPredifinedCell[i, j] = notEmptied;
                    if (notEmptied)
                    {
                        SudokuTable[i, j].InitAsPredefined(blankedBoard[i, j]);
                    }
                }
            }
            MessageBox.Show(Validator.IsValidBoard(blankedBoard) ? "Board OK" : "Board NIE OK");
        }

        private void ButtonSaveState_Click(object sender, EventArgs e)
        {
            SaveToUserPickedFile();
        }

        private void SaveToUserPickedFile()
        {
            if (saveSudokuDialog.ShowDialog() == DialogResult.OK)
            {
                SudokuSaveLoad.Save(saveSudokuDialog.FileName, board, isPredifinedCell);
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
                var (values, predefined) = SudokuSaveLoad.Load(openSudokuDialog.FileName);
                isPredifinedCell = predefined;
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (predefined[i, j])
                        {
                            SudokuTable[i, j].InitAsPredefined(values[i, j]);
                        }
                        else
                        {
                            SudokuTable[i, j].CellValue = values[i, j];
                        }

                    }
                }
            }
        }

        private void TextBoxSudoku_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            var pole = (sender as Control).Parent as SudokuCell;
            switch (e.KeyCode)
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
            FormMenu.glowneOknoMenu.Show();
            Close();
        }

        private void ButtonSolve_Click(object sender, EventArgs e)
        {
            Solver solver = new Solver { Orderer = new NoOptionOrderer<int>() };
            var solution = solver.Solve(board);
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!SudokuTable[i,j].textBox.ReadOnly)
                    {
                        SudokuTable[i, j].CellValue = solution[i, j];
                    }
                }
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                FormMenu.glowneOknoMenu.Show();
            else if (e.CloseReason != CloseReason.ApplicationExitCall)
                Application.Exit();
        }

        private void ButtonSupportMe_Click(object sender, EventArgs e)
        {
            int suppportsRemaining = int.Parse(labelRemainingSupports.Text);
            if (suppportsRemaining >= 1)
                if (Wspomoz())
                {
                    suppportsRemaining--;
                    labelRemainingSupports.Text = suppportsRemaining.ToString();
                }
        }

        private bool Wspomoz()
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

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            var painter = new Painter() { CellSize = 100, FontSize = 24, LineWidth = 2 };
            var img = painter.CreateImage(board, isPredifinedCell);
            img.Save("last.png", System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
