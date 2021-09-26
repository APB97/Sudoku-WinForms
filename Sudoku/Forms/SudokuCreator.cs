using Sudoku.Properties;
using SudokuLib.Core;
using SudokuLib.OptionOrder;

namespace Sudoku
{
    public class SudokuCreator : ISudokuCreator
    {

        public (int[,] board, bool[,] isPredefined) PopulateBoardWithNewSudoku(IBoard sudokuBoard, SudokuCell[,] cells)
        {
            int[,] board = CreateBoard();
            bool[,] isPredefined = CreatePredefinedTable(board);
            UpdateAllVisualCells(cells, board);
            sudokuBoard.EmptyCells = CountEmptyCells(board);
            return (board, isPredefined);
        }

        private int[,] CreateBoard()
        {
            int[,] emptyBoard = new int[9, 9];
            Solver solver = new Solver() { Orderer = new OptionRandomizedOrderer<int>() };
            int[,] solvedBoard = solver.Solve(emptyBoard);
            return SudokuBlanker.MakeBlanks(solvedBoard, Settings.Default.DesiredBlanks);
        }

        private bool[,] CreatePredefinedTable(int[,] board)
        {
            bool[,] isPredefined = new bool[9, 9];
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    isPredefined[y, x] = board[y, x] != 0;
                }
            }
            return isPredefined;
        }

        private void UpdateAllVisualCells(SudokuCell[,] cells, int[,] board)
        {
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    InitializeCellStateIfPredifinedAtLocation(cells[y, x], board[y, x]);
                }
            }
        }

        private void InitializeCellStateIfPredifinedAtLocation(SudokuCell sudokuCell, int cellValue)
        {
            if (cellValue != 0)
            {
                sudokuCell.InitAsPredefined(cellValue);
            }
        }

        public static int CountEmptyCells(int[,] board)
        {
            int count = 0;
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    if (board[y,x] == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
