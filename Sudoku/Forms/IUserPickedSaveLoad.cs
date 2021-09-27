namespace Sudoku
{
    public interface IUserPickedSaveLoad
    {
        (int[,] board, bool[,] isPredefinedCell) LoadFromUserPickedFile(IBoard sudokuBoard, ICell[,] cells);
        void SaveToUserPickedFile(int[,] board, bool[,] isPredefinedCell);
    }
}