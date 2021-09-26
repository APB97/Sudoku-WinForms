using SudokuLib.Core;
using System.Windows.Forms;

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

        public void SaveToUserPickedFile(int[,] board, bool[,] isPredefinedCell)
        {
            if (saveSudokuDialog.ShowDialog() == DialogResult.OK)
            {
                SudokuSaveLoad.Save(saveSudokuDialog.FileName, board, isPredefinedCell);
            }
        }

        public (int[,] board, bool[,] isPredefinedCell) LoadFromUserPickedFile(SudokuCell[,] cells)
        {
            if (openSudokuDialog.ShowDialog() == DialogResult.OK)
            {
                var (board, isPredefinedCell) = SudokuSaveLoad.Load(openSudokuDialog.FileName);
                LoadAllCellStates(cells, board, isPredefinedCell);
                return (board, isPredefinedCell);
            }
            return default;
        }

        private void LoadAllCellStates(SudokuCell[,] cells, int[,] board, bool[,] isPredefinedCell)
        {
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    InitializeCellStateToLoadedValue(cells[y, x], board[y, x], isPredefinedCell[y, x]);
                }
            }
        }

        private void InitializeCellStateToLoadedValue(SudokuCell cell, int value, bool isPredefined)
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
