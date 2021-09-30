namespace Sudoku
{
    public interface IUserPickedSaveLoad
    {
        (int[,] board, bool[,] isPredefinedCell, int supportsAvailable) LoadFromUserPickedFile(IBoard sudokuBoard, ICell[,] cells);
        void SaveToUserPickedFile(int[,] board, bool[,] isPredefinedCell, SudokuSupporter supporter);
    }
}