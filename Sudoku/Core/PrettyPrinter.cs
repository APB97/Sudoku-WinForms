using System.Text;
using SudokuLib.Helpers;

namespace SudokuLib.Core
{
    public class PrettyPrinter
    {
        public string SudokuToString(int[,] board)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append('=', 41).AppendLine();
            for (int i = 0; i < SudokuConstants.SudokuSize; i++)
            {
                builder.Append('|', 2);
                for (int j = 0; j < SudokuConstants.SudokuSize; j++)
                {
                    builder.Append(' ');
                    if (board[i, j] != SudokuConstants.EmptyCellValue) builder.Append(board[i, j]);
                    else builder.Append(' ');
                    builder.Append(' ');
                    builder.Append('|');
                    if (j % 3 == 2) builder.Append('|');
                }

                builder.AppendLine();
                if (i % 3 == 2) builder.Append('=', 41).AppendLine();
                else builder.Append('-', 41).AppendLine();
            }

            return builder.ToString();
        }
    }
}