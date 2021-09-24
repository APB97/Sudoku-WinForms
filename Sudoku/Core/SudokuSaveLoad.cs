using System.IO;
using System.Text;
using SudokuLib.Helpers;
using static SudokuLib.Helpers.SudokuConstants;

namespace SudokuLib.Core
{
    public class SudokuSaveLoad
    {
        public static void Save(string destination, int[,] boardValues, bool[,] boardCellStates)
        {
            if (SudokuHelper.HasIncorrectDimensions(boardValues) || SudokuHelper.HasIncorrectDimensions(boardCellStates)) return;

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < SudokuSize; i++)
            {
                for (int j = 0; j < SudokuSize; j++)
                    builder.Append(boardValues[i, j]);

                builder.AppendLine();
            }

            for (int i = 0; i < SudokuSize; i++)
            {
                for (int j = 0; j < SudokuSize; j++)
                    builder.Append(boardCellStates[i, j] ? 1 : 0);

                builder.AppendLine();
            }
            
            File.WriteAllText(destination, builder.ToString());
        }

        public static (int[,] values, bool[,] predefined) Load(string source)
        {
            int[,] boardValues = new int[SudokuSize, SudokuSize];
            bool[,] boardPredefined = new bool[SudokuSize, SudokuSize];

            string[] fileLines = File.ReadAllLines(source);
            for (int i = 0; i < SudokuSize; i++)
            {
                int secondaryIndex = i + SudokuSize;
                for (int j = 0; j < SudokuSize; j++)
                {
                    boardValues[i, j] = fileLines[i][j] - '0';
                    boardPredefined[i, j] = fileLines[secondaryIndex][j] == '1';
                }
            }

            return (boardValues, boardPredefined);
        }
    }
}