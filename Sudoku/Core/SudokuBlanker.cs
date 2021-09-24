using System;
using System.Collections.Generic;
using System.Linq;
using SudokuLib.OptionOrder;
using static SudokuLib.Helpers.SudokuHelper;
using static SudokuLib.Helpers.SudokuConstants;

namespace SudokuLib.Core
{
    public static class SudokuBlanker
    {
        public static int[,] MakeBlanks(int[,] board, int targetAmount)
        {
            if (!(board.Clone() is int[,] blankedBoard)) return null;
            Random random = new Random();
            (int row, int column) lastClearedCell = new ValueTuple<int, int>();
            var range0To9 = Enumerable.Range(0, SudokuSize).ToArray();
            List<(int row, int column)> busyCells = range0To9.Join(range0To9, _ => 0, _ => 0, (r, c) => (r, c)).ToList();
            bool hasOneAndOnlySolution = true;
            for (int i = 0; i < targetAmount && hasOneAndOnlySolution; i++)
            {
                var chosenOne = SelectPositionToBlank(random, busyCells);
                lastClearedCell = chosenOne;
                blankedBoard[chosenOne.row, chosenOne.column] = EmptyCellValue;
                hasOneAndOnlySolution = HasOneAndOnlySolution(blankedBoard);
            }

            if (!hasOneAndOnlySolution)
                blankedBoard[lastClearedCell.row, lastClearedCell.column] = board[lastClearedCell.row, lastClearedCell.column];

            return blankedBoard;
        }

        private static (int row, int column) SelectPositionToBlank(Random random, List<(int row, int column)> busyCells)
        {
            var index = random.Next(busyCells.Count);
            var selectPositionToBlank = busyCells[index];
            busyCells.RemoveAt(index);
            return selectPositionToBlank;
        }

        public static bool HasOneAndOnlySolution(int[,] board)
        {
            if (HasIncorrectDimensions(board)) return false;

            int[,] solutionFromOne = new Solver{Orderer = new NoOptionOrderer<int>()}.Solve(board);
            int[,] solutionFromNine = new Solver{Orderer = new OptionReverseOrderer<int>()}.Solve(board);

            for (int i = 0; i < SudokuSize; i++)
                for (int j = 0; j < SudokuSize; j++)
                    if (solutionFromOne[i, j] != solutionFromNine[i, j])
                        return false;
            return true;
        }
    }
}