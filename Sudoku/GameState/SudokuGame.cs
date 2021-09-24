using System.Threading.Tasks;
using SudokuLib.Core;
using SudokuLib.Helpers;

namespace SudokuLib.GameState
{
    public class SudokuGame
    {
        protected int[,] Board;
        protected SudokuCellState[,] CellStates;
        private readonly int _targetBlanks;

        public SudokuGame(int targetBlanks, int allowedMistakes)
        {
            _targetBlanks = targetBlanks;
            SudokuGameRules = new SudokuGameRules(allowedMistakes);
            CellStates = new SudokuCellState[SudokuConstants.SudokuSize, SudokuConstants.SudokuSize];
        }

        protected SudokuValidator CellValidator { get; set; }
        public SudokuGameRules SudokuGameRules { get; }
        
        public int this[int row, int column] => Board[row, column];

        public virtual async Task CreateSudoku(object cells) => await Task.Run(GenerateSudoku);

        private void GenerateSudoku()
        {
            Board = SudokuBlanker.MakeBlanks(CellValidator.Solution, _targetBlanks);
            SudokuGameRules.RemainingToFill = SudokuGameRules.CalculateEmpties(Board);
        }

        public void RecoverState(SudokuSaveState state)
        {
            Board = state.Board;
            CellStates = state.CellStates;
            SudokuGameRules.RemainingPossibleMistakes = state.RemainingPossibleMistakes;
        }

        public SudokuSaveState GetBoardState() => new SudokuSaveState(CellValidator.Solution, Board, CellStates,
            SudokuGameRules.RemainingPossibleMistakes);

        protected void ClearCellState(int row, int column)
        {
            Board[row, column] = 0;
            CellStates[row, column] = SudokuCellState.Empty;
        }
    }
}