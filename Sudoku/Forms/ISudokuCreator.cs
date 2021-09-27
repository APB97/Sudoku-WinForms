namespace Sudoku
{
    public interface ISudokuCreator
    {
        (int[,] board, bool[,] isPredefined) PopulateBoardWithNewSudoku(IBoard sudokuBoard, ICell[,] cells);
    }
}