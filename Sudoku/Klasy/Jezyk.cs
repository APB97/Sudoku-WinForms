using Sudoku.Interfejsy;

namespace Sudoku
{
    static class Jezyk
    {
        public static IKomunikaty Komunikaty { get; set; }

        static Jezyk()
        {
            Komunikaty = new KomunikatyPL();
        }
    }
}
