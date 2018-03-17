using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    static class SudokuSolver
    {
        static LinkedList<PoleSudoku> listaPol;

        static readonly List<int> mozliweWartosci = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

        public static void Rozwiaz(PoleSudoku[,] polaSudoku)
        {
            listaPol = new LinkedList<PoleSudoku>();
            int ilePustych = 0;
            foreach (var item in polaSudoku)
            {
                if (!item.textBox.Font.Bold)
                {
                    ++ilePustych;
                    item.OczyscPole();
                }
            }
            if (ilePustych == 0)
                return;
            for (int i = 0; i < 9; ++i)
                for (int j = 0; j < 9; ++j)
                    listaPol.AddLast(polaSudoku[i, j]);

            if (!Uzupelnij(polaSudoku))
                System.Windows.Forms.MessageBox.Show("Brak rozwiazania!");
            else
            {
                foreach (var pole in polaSudoku)
                    if (!pole.textBox.Font.Bold)
                        pole.ZawartoscPola = pole.WartoscPola.ToString();
            }
        }

        private static bool Uzupelnij(PoleSudoku[,] polaSudoku)
        {
            var pole = listaPol.First;
            listaPol.RemoveFirst();

            if (!pole.Value.textBox.Font.Bold)
            {
                HashSet<int> wartosciSasiadow = new HashSet<int>();
                List<int> opcje;

                foreach (var sasiad in pole.Value.sasiedzi)
                {
                    var wartosc = polaSudoku[sasiad.Y, sasiad.X].WartoscPola;
                    if (wartosc != 0)
                        wartosciSasiadow.Add(wartosc);
                }

                opcje = new List<int>(mozliweWartosci.Except(wartosciSasiadow));
                opcje.Shuffle();

                foreach (var opcja in opcje)
                {
                    pole.Value.WartoscPola = opcja;
                    if (listaPol.Count == 0)
                        return true;
                    if (Uzupelnij(polaSudoku))
                    {
                        return true;
                    }
                }

                pole.Value.WartoscPola = 0;
                listaPol.AddFirst(pole);
                return false;
            }
            else
            {
                if (listaPol.Count == 0)
                    return true;
                if (Uzupelnij(polaSudoku))
                    return true;
                listaPol.AddFirst(pole);
                return false;
            }
        }
    }
}
