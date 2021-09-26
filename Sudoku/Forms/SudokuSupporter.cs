using System.Collections.Generic;
using System.Linq;

namespace Sudoku
{
    public class SudokuSupporter
    {
        private readonly List<int> possibleValues = Enumerable.Range(1, 9).ToList();

        private int suppportsRemaining = 3;

        public int SuppportsRemaining => suppportsRemaining;

        public void RequestSupport(IBoard board, SudokuCell[,] sudokuCells)
        {
            if (suppportsRemaining > 0)
            {
                SupportMe(board, sudokuCells);
            }
        }

        private void SupportMe(IBoard board, SudokuCell[,] sudokuCells)
        {
            foreach (var cell in sudokuCells)
            {
                if (!cell.textBox.ReadOnly)
                {
                    HashSet<int> neigborValues = FindAllNeighborValues(sudokuCells, cell);
                    List<int> options = new List<int>(possibleValues.Except(neigborValues));
                    if (options.Count == 1)
                    {
                        if (cell.CellValue == 0)
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

        private static HashSet<int> FindAllNeighborValues(SudokuCell[,] sudokuCells, SudokuCell cell)
        {
            HashSet<int> neigborValues = new HashSet<int>();
            AddNonZeroNeighborValues(sudokuCells, cell, neigborValues);
            return neigborValues;
        }

        private static void AddNonZeroNeighborValues(SudokuCell[,] sudokuCells, SudokuCell cell, HashSet<int> neigborValues)
        {
            foreach (var neighbor in cell.Neighbors)
            {
                AddValueIfNonZero(sudokuCells, neigborValues, neighbor);
            }
        }

        private static void AddValueIfNonZero(SudokuCell[,] sudokuCells, HashSet<int> neigborValues, Location neighbor)
        {
            var cellValue = sudokuCells[neighbor.Y, neighbor.X].CellValue;
            if (cellValue != 0)
            {
                neigborValues.Add(cellValue);
            }
        }
    }
}
