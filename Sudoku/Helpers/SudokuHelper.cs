using System.Collections.Generic;
using System.Linq;
using static SudokuLib.Helpers.SudokuConstants;

namespace SudokuLib.Helpers
{
    public static class SudokuHelper
    {
        public static IEnumerable<(int, int)> GetWithinSquareNeighbours(int row, int column)
        {
            return Enumerable.Range(row / 3 * 3, 3)
                .Join(Enumerable.Range(column / 3 * 3, 3), i => 0, i => 0, (r, c) => (r, c));
        }

        public static IEnumerable<(int, int)> GetVerticalNeighbours(int column)
        {
            return Enumerable.Range(0, SudokuSize)
                .Zip(Enumerable.Repeat(column, SudokuSize), (r, c) => (r, c));
        }

        public static IEnumerable<(int, int)> GetHorizontalNeighbours(int row)
        {
            return Enumerable.Repeat(row, SudokuSize)
                .Zip(Enumerable.Range(0, SudokuSize), (r, c) => (r, c));
        }

        public static bool HasIncorrectDimensions<T>(T[,] board)
        {
            return board.Rank != 2 || board.GetLength(0) != SudokuSize || board.GetLength(1) != SudokuSize;
        }
    }
}