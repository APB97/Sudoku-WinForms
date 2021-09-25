using System.Linq;
using static SudokuLib.Helpers.SudokuConstants;
using static SudokuLib.Helpers.SudokuHelper;

namespace SudokuLib.Core
{
    public class Validator
    {
        public static bool IsValid(int[,] sudokuBoard, (int row, int column) cellPosition)
        {
            var (row, column) = cellPosition;
            int value = sudokuBoard[column, row];
            if (value == EmptyCellValue) return true;
            bool isUniqueInColumn = GetVerticalNeighbours(column)
                        .Select(((int r, int c) cell) => sudokuBoard[cell.c, cell.r]).Count(v => v == value) == 1;
            bool isUniqueInRow = GetHorizontalNeighbours(row)
                        .Select(((int r, int c) cell) => sudokuBoard[cell.c, cell.r]).Count(v => v == value) == 1;
            bool isUniqueInSquare = GetWithinSquareNeighbours(row, column)
                        .Select(((int r, int c) cell) => sudokuBoard[cell.c, cell.r]).Count(v => v == value) == 1;
            return isUniqueInColumn && isUniqueInRow && isUniqueInSquare;
        }

        public static bool IsValidBoard(int[,] sudokuBoard)
        {
            if (HasIncorrectDimensions(sudokuBoard)) return false;
            for (int y = 0; y < SudokuSize; y++)
                for (int x = 0; x < SudokuSize; x++)
                    if (!IsValid(sudokuBoard, (y, x)))
                        return false;
            return true;
        }
    }
}