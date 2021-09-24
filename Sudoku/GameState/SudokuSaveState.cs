using System;

namespace SudokuLib.GameState
{
    [Serializable]
    public class SudokuSaveState
    {
        public int[,] Solution;
        public int[,] Board;
        public SudokuCellState[,] CellStates;
        public int RemainingPossibleMistakes;

        public SudokuSaveState(int[,] solution, int[,] board, SudokuCellState[,] cellStates, int remainingPossibleMistakes)
        {
            Solution = solution;
            Board = board;
            RemainingPossibleMistakes = remainingPossibleMistakes;
            CellStates = cellStates;
        }
    }
}