using Sudoku.Properties;
using SudokuLib.Core;
using System.Windows.Forms;
using static SudokuLib.Helpers.SudokuConstants;

namespace Sudoku
{
    public class WinFormsSaveLoad : IUserPickedSaveLoad
    {
        private readonly SaveFileDialog saveSudokuDialog;
        private readonly OpenFileDialog openSudokuDialog;

        public WinFormsSaveLoad()
        {
            saveSudokuDialog = new SaveFileDialog() { Filter = "Text files|*.txt|All files|*.*", DefaultExt = "txt" };
            openSudokuDialog = new OpenFileDialog() { Filter = "Text files|*.txt|All files|*.*", DefaultExt = "txt" };
        }

        ~WinFormsSaveLoad()
        {
            saveSudokuDialog.Dispose();
            openSudokuDialog.Dispose();
        }

        public void SaveToUserPickedFile(int[,] board, bool[,] isPredefinedCell, SudokuSupporter supporter)
        {
            if (saveSudokuDialog.ShowDialog() == DialogResult.OK)
            {
                SudokuSaveLoad.Save(saveSudokuDialog.FileName, board, isPredefinedCell, supporter.SuppportsRemaining);
            }
        }

        public (int[,] board, bool[,] isPredefinedCell, int supportsAvailable) LoadFromUserPickedFile(IBoard sudokuBoard, ICell[,] cells)
        {
            if (openSudokuDialog.ShowDialog() == DialogResult.OK)
            {
                var (board, isPredefinedCell, supports) = SudokuSaveLoad.Load(openSudokuDialog.FileName);
                LoadAllCellStates(cells, board, isPredefinedCell);
                sudokuBoard.EmptyCells = SudokuCreator.CountEmptyCells(board);
                return (board, isPredefinedCell, supports);
            }
            return (default, default, Settings.Default.SupportsAvailable);
        }

        private void LoadAllCellStates(ICell[,] cells, int[,] board, bool[,] isPredefinedCell)
        {
            for (int y = 0; y < SudokuSize; y++)
            {
                for (int x = 0; x < SudokuSize; x++)
                {
                    InitializeCellStateToLoadedValue(cells[y, x], board[y, x], isPredefinedCell[y, x]);
                }
            }
        }

        private void InitializeCellStateToLoadedValue(ICell cell, int value, bool isPredefined)
        {
            if (isPredefined)
            {
                cell.InitAsPredefined(value);
            }
            else
            {
                cell.CellValue = value;
            }
        }
    }
}
