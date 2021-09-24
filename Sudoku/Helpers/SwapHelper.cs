namespace SudokuLib.Helpers
{
    public static class SwapHelper
    {
        public static void Swap<T>(ref T first, ref T second)
        {
            T temporary = first;
            first = second;
            second = temporary;
        }
    }
}