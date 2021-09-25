namespace Sudoku
{
    public interface IUserPickedSaveLoad
    {
        (int[,] board, bool[,] isPredefinedCell) LoadFromUserPickedFile(SudokuCell[,] cells);
        void SaveToUserPickedFile(int[,] board, bool[,] isPredefinedCell);
    }
}