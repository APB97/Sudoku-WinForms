using SudokuLib.Core;
using SudokuLib.Helpers;
using SudokuLib.OptionOrder;

namespace SudokuLib.GameState
{
    public abstract class SudokuValidator
    {
        private readonly SudokuGame _sudokuGame;
        private readonly SudokuGameRules _gameRules;

        public int[,] Solution { get; }

        protected SudokuValidator(SudokuGame sudokuGame, SudokuGameRules gameRules)
        {
            _sudokuGame = sudokuGame;
            _gameRules = gameRules;
            Solution = new Solver {Orderer = new OptionRandomizedOrderer<int>()}.Solve(
                new int[SudokuConstants.SudokuSize, SudokuConstants.SudokuSize]);
        }

        protected SudokuValidator(SudokuGame sudokuGame, int[,] solution, SudokuGameRules gameRules)
        {
            _sudokuGame = sudokuGame;
            Solution = solution;
            _gameRules = gameRules;
        }

        public SudokuCellState ValidateNewValue(object cell, int row, int column)
        {
            if (IsCorrectAt(row, column))
            {
                FixValue(cell);
                _gameRules.RemainingToFill--;
                return SudokuCellState.Correct;
            }

            MarkError(cell);
            _gameRules.RemainingPossibleMistakes--;
            return SudokuCellState.Mistaken;
        }

        protected abstract void MarkError(object cell);

        protected abstract void FixValue(object cell);

        public bool IsCorrectAt(int row, int column)
        {
            return _sudokuGame[row, column] == Solution[row, column];
        }
    }
}