namespace SudokuLib.GameState
{
    public abstract class VisualCell
    {
        public abstract void SetValue(int cellValue);
        public abstract void FixValueInCell();
        public abstract void LightRed();
        public abstract void MakeBold();
        public abstract object IndexArrayOfCellsObject(object cells, int i, int j);
    }
}