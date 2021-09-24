using System.Threading.Tasks;
using SudokuLib.Core;
using SudokuLib.Helpers;

namespace SudokuLib.GameState
{
    public abstract class SudokuGame
    {
        protected int[,] Board;
        protected SudokuCellState[,] CellStates;
        private readonly int _targetBlanks;

        protected SudokuGame(int targetBlanks, int allowedMistakes)
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
            CellValidator = CreateNewSudokuValidator(state);
            Board = state.Board;
            CellStates = state.CellStates;
            SudokuGameRules.RemainingPossibleMistakes = state.RemainingPossibleMistakes;
        }

        protected abstract SudokuValidator CreateNewSudokuValidator(SudokuSaveState state);

        public SudokuSaveState GetBoardState() => new SudokuSaveState(CellValidator.Solution, Board, CellStates,
            SudokuGameRules.RemainingPossibleMistakes);

        public abstract void AddListener(object cell, int row, int column);

        protected void ClearCellState(int row, int column)
        {
            Board[row, column] = 0;
            CellStates[row, column] = SudokuCellState.Empty;
        }

        protected virtual void FixCellValue(object cell, int row, int column) =>
            CellStates[row, column] = SudokuCellState.Fixed;

        protected void SetValue(object cell, int row, int column)
        {
            if (CellValidator.IsCorrectAt(row, column))
                FixCellValue(cell, row, column);
            else
                AddListener(cell, row, column);
        }
    }
}