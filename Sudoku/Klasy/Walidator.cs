﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Walidator
    {
        public static bool SprawdzPole(PoleSudoku[,] polaSudoku, Pozycja pozycjaPola)
        {
            List<int> kwadrat, kolumna, wiersz;
            kwadrat = new List<int>();
            kolumna = new List<int>();
            wiersz = new List<int>();
            
            int h = (pozycjaPola.X / 3) * 3;///5
            int v = (pozycjaPola.Y / 3) * 3;///7
            for (int j = v; j < v + 3; ++j)
                for (int k = h; k < h + 3; ++k)
                {
                    int wartosc = polaSudoku[j, k].WartoscPola;
                    if (wartosc != 0)
                        kwadrat.Add(wartosc);
                }

            for (int j = 0; j < 9; ++j)
            {
                int wartoscWKolumnnie = polaSudoku[j, i].WartoscPola;
                int wartoscWWierszu = polaSudoku[i, j].WartoscPola;
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

        public static bool SprawdzCalaTablice(PoleSudoku[,] polaSudoku)
        {
            List<int> kwadrat, wiersz, kolumna;
            for (int i = 0; i < 9; ++i)
            {
                int h, v;
                kwadrat = new List<int>();
                kolumna = new List<int>();
                wiersz = new List<int>();
                h = (i % 3) * 3;
                v = (i / 3) * 3;
                for (int j = v; j < v + 3; ++j)
                    for (int k = h; k < h + 3; ++k)
                    {
                        int wartosc = polaSudoku[j, k].WartoscPola;
                        if (wartosc != 0)
                            kwadrat.Add(wartosc);
                    }

                for (int j = 0; j < 9; ++j)
                {
                    int wartoscWKolumnnie = polaSudoku[j, i].WartoscPola;
                    int wartoscWWierszu = polaSudoku[i, j].WartoscPola;
                    if (wartoscWKolumnnie != 0)
                        kolumna.Add(wartoscWKolumnnie);
                    if (wartoscWWierszu != 0)
                        wiersz.Add(wartoscWWierszu);
                }

                if (kwadrat.Distinct().Count() != kwadrat.Count || kolumna.Distinct().Count() != kolumna.Count
                    || wiersz.Distinct().Count() != wiersz.Count)
                    return false;
            }
            return true;
        }
    }
}
