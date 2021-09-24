using System.Collections.Generic;
using System.Linq;

namespace Sudoku
{
    static class SudokuSolver
    {
        static LinkedList<PoleSudoku> listaPolPustych;

        static readonly List<int> mozliweWartosci = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

        public static void Rozwiaz(PoleSudoku[,] polaSudoku)
        {
            listaPolPustych = new LinkedList<PoleSudoku>();
            for (int i = 0; i < 9; ++i)
                for (int j = 0; j < 9; ++j)
                    if (!polaSudoku[i, j].textBox.Font.Bold)
                    {
                        listaPolPustych.AddLast(polaSudoku[i, j]);
                        polaSudoku[i, j].OczyscPole();
                    }
            if (listaPolPustych.Count == 0)
                return;

            if (!Uzupelnij(polaSudoku))
                System.Windows.Forms.MessageBox.Show("Brak rozwiazania!");
            else
                foreach (var pole in polaSudoku)
                    if (!pole.textBox.Font.Bold)
                        pole.ZawartoscPola = pole.WartoscPola.ToString();
        }

        private static bool Uzupelnij(PoleSudoku[,] polaSudoku)
        {
            var pole = listaPolPustych.First;
            listaPolPustych.RemoveFirst();

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
                if (listaPolPustych.Count == 0)
                    return true;
                if (Uzupelnij(polaSudoku))
                {
                    return true;
                }
            }

            pole.Value.WartoscPola = 0;
            listaPolPustych.AddFirst(pole);
            return false;
        }
    }
}
