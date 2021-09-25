using System.Windows.Forms;

namespace Sudoku
{
    public interface ISudokuLayoutCreator
    {
        void CreateSudokuTable(SudokuCell[,] sudokuCells, TableLayoutPanel layoutPanel);
    }
}