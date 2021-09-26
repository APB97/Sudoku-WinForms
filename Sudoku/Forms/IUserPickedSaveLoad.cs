namespace Sudoku
{
    public interface IUserPickedSaveLoad
    {
        (int[,] board, bool[,] isPredefinedCell) LoadFromUserPickedFile(IBoard sudokuBoard, SudokuCell[,] cells);
        void SaveToUserPickedFile(int[,] board, bool[,] isPredefinedCell);
    }
}