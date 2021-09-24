namespace SudokuLib.GameState
{
    public interface IVisualCell
    {
        void SetValue(int cellValue);
        void FixValueInCell();
        void LightRed();
        void MakeBold();
        object IndexArrayOfCellsObject(object cells, int i, int j);
    }
}