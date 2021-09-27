using System.Collections.Generic;
using System.Linq;
using static SudokuLib.Helpers.SudokuConstants;

namespace Sudoku
{
    public class SudokuSupporter
    {
        private readonly List<int> possibleValues = Enumerable.Range(1, 9).ToList();

        private int suppportsRemaining = 3;

        public int SuppportsRemaining => suppportsRemaining;

        public void RequestSupport(IBoard board, ICell[,] sudokuCells)
        {
            if (suppportsRemaining > 0)
            {
                SupportMe(board, sudokuCells);
            }
        }

        private void SupportMe(IBoard board, ICell[,] sudokuCells)
        {
            foreach (var cell in sudokuCells)
            {
                if (!cell.ReadOnly)
                {
                    HashSet<int> neigborValues = FindAllNeighborValues(sudokuCells, cell);
                    List<int> options = new List<int>(possibleValues.Except(neigborValues));
                    if (options.Count == 1)
                    {
                        if (cell.CellValue == EmptyCellValue)
                        {
                            board.EmptyCells--;
                        }
                        cell.CellValue = options[0];
                        suppportsRemaining--;
                        return;
                    }
                }
            }
        }

        private static HashSet<int> FindAllNeighborValues(ICell[,] sudokuCells, ICell cell)
        {
            HashSet<int> neigborValues = new HashSet<int>();
            AddNonZeroNeighborValues(sudokuCells, cell, neigborValues);
            return neigborValues;
        }

        private static void AddNonZeroNeighborValues(ICell[,] sudokuCells, ICell cell, HashSet<int> neigborValues)
        {
            foreach (var neighbor in cell.Neighbors)
            {
                AddValueIfNonZero(sudokuCells, neigborValues, neighbor);
            }
        }

        private static void AddValueIfNonZero(ICell[,] sudokuCells, HashSet<int> neigborValues, Location neighbor)
        {
            var cellValue = sudokuCells[neighbor.Y, neighbor.X].CellValue;
            if (cellValue != EmptyCellValue)
            {
                neigborValues.Add(cellValue);
            }
        }
    }
}
