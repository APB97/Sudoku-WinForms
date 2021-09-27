using Sudoku.Properties;
using SudokuLib.Core;
using SudokuLib.OptionOrder;
using static SudokuLib.Helpers.SudokuConstants;

namespace Sudoku
{
    public class SudokuCreator : ISudokuCreator
    {
        public (int[,] board, bool[,] isPredefined) PopulateBoardWithNewSudoku(IBoard sudokuBoard, ICell[,] cells)
        {
            int[,] board = CreateBoard();
            bool[,] isPredefined = CreatePredefinedTable(board);
            UpdateAllVisualCells(cells, board);
            sudokuBoard.EmptyCells = CountEmptyCells(board);
            return (board, isPredefined);
        }

        private int[,] CreateBoard()
        {
            int[,] emptyBoard = new int[SudokuSize, SudokuSize];
            Solver solver = new Solver() { Orderer = new OptionRandomizedOrderer<int>() };
            int[,] solvedBoard = solver.Solve(emptyBoard);
            return SudokuBlanker.MakeBlanks(solvedBoard, Settings.Default.DesiredBlanks);
        }

        private bool[,] CreatePredefinedTable(int[,] board)
        {
            bool[,] isPredefined = new bool[SudokuSize, SudokuSize];
            for (int y = 0; y < SudokuSize; y++)
            {
                for (int x = 0; x < SudokuSize; x++)
                {
                    isPredefined[y, x] = board[y, x] != EmptyCellValue;
                }
            }
            return isPredefined;
        }

        private void UpdateAllVisualCells(ICell[,] cells, int[,] board)
        {
            for (int y = 0; y < SudokuSize; y++)
            {
                for (int x = 0; x < SudokuSize; x++)
                {
                    InitializeCellStateIfNotEmpty(cells[y, x], board[y, x]);
                }
            }
        }

        private void InitializeCellStateIfNotEmpty(ICell sudokuCell, int cellValue)
        {
            if (cellValue != EmptyCellValue)
            {
                sudokuCell.InitAsPredefined(cellValue);
            }
        }

        public static int CountEmptyCells(int[,] board)
        {
            int count = 0;
            for (int y = 0; y < SudokuSize; y++)
            {
                for (int x = 0; x < SudokuSize; x++)
                {
                    if (board[y,x] == EmptyCellValue)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
