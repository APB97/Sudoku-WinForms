using System;
using System.Linq;

namespace SudokuLib.GameState
{
    public class SudokuGameRules
    {
        private int _remainingToFill;
        private int _remainingPossibleMistakes;

        public SudokuGameRules(int remainingPossibleMistakes)
        {
            _remainingPossibleMistakes = remainingPossibleMistakes;
        }

        public int RemainingToFill
        {
            get => _remainingToFill;
            set
            {
                _remainingToFill = value;
                if (_remainingToFill == 0) OnFinishSuccess();
            }
        }

        public int RemainingPossibleMistakes
        {
            get => _remainingPossibleMistakes;
            internal set
            {
                _remainingPossibleMistakes = value;
                if (_remainingPossibleMistakes < 0) OnFinishFailure();
            }
        }

        public event Action OnFinishSuccess = delegate { };
        public event Action OnFinishFailure = delegate { };

        public static int CalculateEmpties(int[,] board)
        {
            return board.Cast<int>().Count(cellValue => cellValue == 0);
        }
    }
}