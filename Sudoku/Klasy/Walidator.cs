using System.Collections.Generic;
using System.Linq;

namespace Sudoku
{
    class Walidator
    {
        public static bool SprawdzPole(SudokuCell[,] polaSudoku, Location pozycjaPola)
        {
            List<int> kwadrat, kolumna, wiersz;
            kwadrat = new List<int>();
            kolumna = new List<int>();
            wiersz = new List<int>();
            
            int h = (pozycjaPola.X / 3) * 3;
            int v = (pozycjaPola.Y / 3) * 3;
            for (int j = v; j < v + 3; ++j)
                for (int k = h; k < h + 3; ++k)
                {
                    int wartosc = polaSudoku[j, k].CellValue;
                    if (wartosc != 0)
                        kwadrat.Add(wartosc);
                }

            for (int j = 0; j < 9; ++j)
            {
                int wartoscWKolumnnie = polaSudoku[j, pozycjaPola.X].CellValue;
                int wartoscWWierszu = polaSudoku[pozycjaPola.Y, j].CellValue;
                if (wartoscWKolumnnie != 0)
                    kolumna.Add(wartoscWKolumnnie);
                if (wartoscWWierszu != 0)
                    wiersz.Add(wartoscWWierszu);
            }

            if (kwadrat.Distinct().Count() != kwadrat.Count || kolumna.Distinct().Count() != kolumna.Count
                    || wiersz.Distinct().Count() != wiersz.Count)
                return false;

            return true;
        }

        public static bool SprawdzCalaTablice(SudokuCell[,] polaSudoku)
        {
            for (int i = 0; i < 9; ++i)
                for (int j = 0; j < 9; j++)
                    if (!SprawdzPole(polaSudoku, new Location(j, i)))
                        return false;
            return true;
        }
    }
}
