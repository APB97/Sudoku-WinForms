namespace Sudoku
{
    public interface ISudokuPrinter
    {
        void Print();
        void Save(int[,] board, bool[,] isPredefinedCell);
    }
}