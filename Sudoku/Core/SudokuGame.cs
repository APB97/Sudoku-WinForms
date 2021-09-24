using SudokuLib.Helpers;
using static SudokuLib.Helpers.SudokuConstants;

namespace SudokuLib.Core
{
    public class SudokuGame
    {
        public static bool[,] GenerateCellStateArray(int[,] board)
        {
            if (SudokuHelper.HasIncorrectDimensions(board)) return null;

            bool[,] cellStates = new bool[SudokuSize, SudokuSize];
            for (int i = 0; i < SudokuSize; i++)
                for (int j = 0; j < SudokuSize; j++)
                    cellStates[i, j] = board[i, j] != EmptyCellValue;
            return cellStates;
        }
    }
}