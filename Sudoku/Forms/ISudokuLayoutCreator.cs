using System.Windows.Forms;

namespace Sudoku
{
    public interface ISudokuLayoutCreator
    {
        IBoard Board { get; set; }

        void CreateSudokuTable(SudokuCell[,] sudokuCells, TableLayoutPanel layoutPanel);
    }
}