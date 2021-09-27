using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static SudokuLib.Helpers.SudokuConstants;

namespace Sudoku
{
    public class WinFormsLayoutCreator : ISudokuLayoutCreator
    {
        private readonly int[] HorizontalDisplacement = new int[9] { 0, 1, 2, 0, 1, 2, 0, 1, 2 };
        private readonly int[] VerticalDisplacement = new int[9] { 0, 0, 0, 1, 1, 1, 2, 2, 2 };

        public IBoard Board { get; set; }

        public void CreateSudokuTable(ICell[,] sudokuCells, TableLayoutPanel layoutPanel)
        {
            void CellTextBox_KeyPress(object sender, PreviewKeyDownEventArgs args) => TryNavigateToNextCell(sender, args.KeyCode, sudokuCells);
            for (int squareId = 0; squareId < SudokuSize; ++squareId)
            {
                Control[] foundTableLayoutMatches = layoutPanel.Controls.Find("tableLayoutPanel" + squareId, false);
                PopulateSquareIfIsTableLayoutPanel(sudokuCells, foundTableLayoutMatches, squareId, CellTextBox_KeyPress);
            }
        }

        private void PopulateSquareIfIsTableLayoutPanel(ICell[,] sudokuCells, Control[] foundTableLayoutMatches, int squareId, PreviewKeyDownEventHandler previewKeyDownHandler)
        {
            if (foundTableLayoutMatches.FirstOrDefault() is TableLayoutPanel currentSquare)
            {
                currentSquare.TabIndex = squareId;
                InitAllCellsInSquare(sudokuCells, currentSquare, squareId, previewKeyDownHandler);
            }
        }

        private void InitAllCellsInSquare(ICell[,] sudokuCells, TableLayoutPanel currentSquare, int squareId, PreviewKeyDownEventHandler previewKeyDownHandler)
        {
            for (int cellNumberInSquare = 0; cellNumberInSquare < SudokuSize; ++cellNumberInSquare)
            {
                InitSudokuCellInSquare(sudokuCells, currentSquare, squareId, cellNumberInSquare, previewKeyDownHandler);
            }
        }

        private void InitSudokuCellInSquare(ICell[,] sudokuCells, TableLayoutPanel currentSquare, int squareId, int cellNumberInSquare, PreviewKeyDownEventHandler TextBoxSudoku_PreviewKeyDown)
        {
            var pole = new SudokuCell(Board, HorizontalDisplacement[cellNumberInSquare] + HorizontalDisplacement[squareId] * 3, VerticalDisplacement[cellNumberInSquare] + VerticalDisplacement[squareId] * 3);
            currentSquare.Controls.Add(pole);
            sudokuCells[VerticalDisplacement[cellNumberInSquare] + VerticalDisplacement[squareId] * 3,
                HorizontalDisplacement[cellNumberInSquare] + HorizontalDisplacement[squareId] * 3] = pole;
            pole.textBox.PreviewKeyDown += TextBoxSudoku_PreviewKeyDown;
            pole.textBox.ForeColor = Color.DimGray;
        }

        private void TryNavigateToNextCell(object sender, Keys keyCode, ICell[,] table)
        {
            var pole = (sender as Control).Parent as ICell;
            switch (keyCode)
            {
                case Keys.Left:
                    if (pole.X > 0)
                        pole = table[pole.Y, pole.X - 1];
                    break;
                case Keys.Right:
                    if (pole.X < 8)
                        pole = table[pole.Y, pole.X + 1];
                    break;
                case Keys.Up:
                    if (pole.Y > 0)
                        pole = table[pole.Y - 1, pole.X];
                    break;
                case Keys.Down:
                    if (pole.Y < 8)
                        pole = table[pole.Y + 1, pole.X];
                    break;
                default:
                    return;
            }
            pole.FocusTextbox();
        }
    }
}
