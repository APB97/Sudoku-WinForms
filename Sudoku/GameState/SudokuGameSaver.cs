using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using SudokuLib.Helpers;

namespace SudokuLib.GameState
{
    public class SudokuGameSaver
    {
        private readonly SudokuGame _sudokuGame;
        private readonly string _lastGameSaveName;
        private readonly VisualCell _visualCell;

        public SudokuGameSaver(SudokuGame sudokuGame, string lastGameSaveName, VisualCell visualCell)
        {
            _sudokuGame = sudokuGame;
            _lastGameSaveName = lastGameSaveName;
            _visualCell = visualCell;
        }

        private int FillUiAndCalculateEmptyCells(object cells, SudokuSaveState state)
        {
            int emptyOnes = SudokuConstants.SudokuSize * SudokuConstants.SudokuSize;

            for (int i = 0; i < SudokuConstants.SudokuSize; i++)
            {
                for (int j = 0; j < SudokuConstants.SudokuSize; j++)
                {
                    object cell = _visualCell.IndexArrayOfCellsObject(cells, i, j);
                    emptyOnes = FillCellAndRecoverItsState(state.Board[i, j], emptyOnes, state.CellStates[i, j]);
                    _sudokuGame.AddListener(cell, i, j);
                }
            }

            return emptyOnes;
        }

        private int FillCellAndRecoverItsState(int cellValue, int emptyOnes, SudokuCellState cellState)
        {
            if (cellValue != 0)
            {
                _visualCell.SetValue(cellValue);
                emptyOnes--;
            }

            // ReSharper disable once SwitchStatementMissingSomeEnumCasesNoDefault
            switch (cellState)
            {
                case SudokuCellState.Fixed:
                    _visualCell.MakeBold();
                    _visualCell.FixValueInCell();
                    break;
                case SudokuCellState.Mistaken:
                    _visualCell.LightRed();
                    break;
                case SudokuCellState.Correct:
                    _visualCell.FixValueInCell();
                    break;
            }

            return emptyOnes;
        }

        public void TrySave()
        {
            if (_sudokuGame.SudokuGameRules.RemainingPossibleMistakes <= 0 || _sudokuGame.SudokuGameRules.RemainingToFill <= 0)
            {
                if (File.Exists(_lastGameSaveName)) File.Delete(_lastGameSaveName);
                return;
            }
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenWrite(_lastGameSaveName))
            {
                SudokuSaveState state = _sudokuGame.GetBoardState();
                formatter.Serialize(stream, state);
            }
        }

        public bool TryLoad(object cells)
        {
            if (!File.Exists(_lastGameSaveName)) return false;
            var state = LoadStateFromFile();
            _sudokuGame.RecoverState(state);
            _sudokuGame.SudokuGameRules.RemainingToFill = FillUiAndCalculateEmptyCells(cells, state);
            return true;
        }

        private SudokuSaveState LoadStateFromFile()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenRead(_lastGameSaveName))
                return (SudokuSaveState)formatter.Deserialize(stream);
        }
    }
}