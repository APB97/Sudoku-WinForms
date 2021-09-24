using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using SudokuLib.OptionOrder;
using static SudokuLib.Helpers.SudokuConstants;
using static SudokuLib.Helpers.SudokuHelper;

namespace SudokuLib.Core
{
    public class Solver
    {
        public IOptionsOrderer<int> Orderer = new NoOptionOrderer<int>();
        
        public int[,] Solve(int[,] board)
        {
            if (HasIncorrectDimensions(board))
                return board;
            
            var emptyCells = new LinkedList<(int row, int column)>();
            for (int i = 0; i < SudokuSize; i++)
                for (int j = 0; j < SudokuSize; j++)
                    if (board[i, j] == EmptyCellValue)
                        emptyCells.AddLast((i, j));

            var solvedBoard = board.Clone() as int[,];
            Fill(solvedBoard, emptyCells);
            return solvedBoard;
        }

        private bool Fill(int[,] board, LinkedList<(int row, int column)> emptyCells)
        {
            var cell = emptyCells.First;
            emptyCells.RemoveFirst();

            Debug.Assert(cell != null, nameof(cell) + " != null");
            var neighbours = GetCellNeighbours(cell.Value);

            var usedValues = new HashSet<int>();
            foreach ((int row, int column) neighbour in neighbours)
                usedValues.Add(board[neighbour.row, neighbour.column]);

            var options = Orderer.Order(Enumerable.Range(1, SudokuSize).Except(usedValues));
            foreach (int option in options)
            {
                board[cell.Value.row, cell.Value.column] = option;
                if (emptyCells.Count == 0)
                    return true;
                if (Fill(board, emptyCells))
                    return true;
            }

            board[cell.Value.row, cell.Value.column] = EmptyCellValue;
            emptyCells.AddFirst(cell);
            return false;
        }

        private static IEnumerable<(int row, int column)> GetCellNeighbours((int row, int column) cell)
        {
            var (row, column) = cell;
            IEnumerable<(int row, int column)> vertical = GetHorizontalNeighbours(row);
            IEnumerable<(int row, int column)> horizontal = GetVerticalNeighbours(column);
            IEnumerable<(int row, int column)> withinSquare = GetWithinSquareNeighbours(row, column);
            var neighbours = new HashSet<(int row, int column)>(vertical.Concat(horizontal).Concat(withinSquare));
            return neighbours;
        }
    }
}