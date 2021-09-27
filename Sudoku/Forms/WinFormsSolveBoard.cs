using SudokuLib.Core;
using SudokuLib.OptionOrder;
using static SudokuLib.Helpers.SudokuConstants;

namespace Sudoku
{
    public class WinFormsSolveBoard
    {
        public void Solve(IBoard sudokuBoard, int[,] board, bool[,] isPredefined, ICell[,] cells)
        {
            Solver solver = new Solver { Orderer = new NoOptionOrderer<int>() };
            var solution = solver.Solve(board);
            ShowSolution(solution, isPredefined, cells);
            sudokuBoard.NotUserSolved = true;
            sudokuBoard.EmptyCells = 0;
        }

        private void ShowSolution(int[,] solution, bool[,] isPredefined, ICell[,] cells)
        {
            for (int y = 0; y < SudokuSize; y++)
            {
                for (int x = 0; x < SudokuSize; x++)
                {
                    ShowSolutionAtLocation(cells[y, x], isPredefined[y, x], solution[y, x]);
                }
            }
        }

        private void ShowSolutionAtLocation(ICell sudokuCell, bool predefined, int value)
        {
            if (!predefined)
            {
                sudokuCell.CellValue = value;
            }
        }
    }
}
