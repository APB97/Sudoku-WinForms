namespace Sudoku
{
    public interface ISudokuCreator
    {
        (int[,] board, bool[,] isPredefined) PopulateBoardWithNewSudoku(SudokuCell[,] cells);
    }
}