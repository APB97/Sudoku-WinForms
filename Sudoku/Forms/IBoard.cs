namespace Sudoku
{
    public interface IBoard
    {
        int[,] Board { get; }
        int EmptyCells { get; set; }
        bool NotUserSolved { get; set; }
    }
}