using System.Collections.Generic;
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
            int value = sudokuBoard[row, column];
            if (value == EmptyCellValue) return true;
            bool isUniqueInColumn = GetVerticalNeighbours(column)
                        .Select(((int r, int c) cell) => sudokuBoard[cell.r, cell.c]).Count(v => v == value) == 1;
            bool isUniqueInRow = GetHorizontalNeighbours(row)
                        .Select(((int r, int c) cell) => sudokuBoard[cell.r, cell.c]).Count(v => v == value) == 1;
            bool isUniqueInSquare = GetWithinSquareNeighbours(row, column)
                        .Select(((int r, int c) cell) => sudokuBoard[cell.r, cell.c]).Count(v => v == value) == 1;
            return isUniqueInColumn && isUniqueInRow && isUniqueInSquare;
        }

        public static bool IsValidBoard(int[,] sudokuBoard)
        {
            if (HasIncorrectDimensions(sudokuBoard)) return false;
            for (int i = 0; i < SudokuSize; i++)
                for (int j = 0; j < SudokuSize; j++)
                    if (!IsValid(sudokuBoard, (i, j)))
                        return false;
            return true;
        }
    }
}