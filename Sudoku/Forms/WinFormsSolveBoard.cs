using SudokuLib.Core;
using SudokuLib.OptionOrder;

namespace Sudoku
{
    public class WinFormsSolveBoard
    {
        public void Solve(int[,] board, bool[,] isPredefined, SudokuCell[,] cells)
        {
            Solver solver = new Solver { Orderer = new NoOptionOrderer<int>() };
            var solution = solver.Solve(board);
            ShowSolution(solution, isPredefined, cells);
        }

        private void ShowSolution(int[,] solution, bool[,] isPredefined, SudokuCell[,] cells)
        {
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    ShowSolutionAtLocation(cells[y, x], isPredefined[y, x], solution[y, x]);
                }
            }
        }

        private void ShowSolutionAtLocation(SudokuCell sudokuCell, bool predefined, int value)
        {
            if (!predefined)
            {
                sudokuCell.CellValue = value;
            }
        }
    }
}
