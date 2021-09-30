using System.IO;
using System.Linq;
using System.Text;
using Sudoku.Properties;
using SudokuLib.Helpers;
using static SudokuLib.Helpers.SudokuConstants;

namespace SudokuLib.Core
{
    public class SudokuSaveLoad
    {
        public static void Save(string destination, int[,] boardValues, bool[,] boardCellStates, int supportsAvailable)
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

            builder.Append(supportsAvailable);
            
            File.WriteAllText(destination, builder.ToString());
        }

        public static (int[,] values, bool[,] predefined, int supportsAvailable) Load(string source)
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

            if (fileLines.Length < SudokuSize + SudokuSize + 1 || !int.TryParse(fileLines[SudokuSize + SudokuSize].Split(' ').First(), out int supports))
            {
                supports = Settings.Default.SupportsAvailable;
            }

            return (boardValues, boardPredefined, supports);
        }
    }
}