namespace Sudoku
{
    /// <summary>
    /// Pozycja pola na planszy
    /// </summary>
    public struct Pozycja
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Pozycja(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
