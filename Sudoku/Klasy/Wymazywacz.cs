﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Wymazywacz
    {
        static LinkedList<int> listaPol;
        static HashSet<Pozycja>[,] sasiedzi = new HashSet<Pozycja>[9,9];
        static int x, y;

        static Wymazywacz()
        {
            for (int iy = 0; iy < 9; ++iy)
                for (int ix = 0; ix < 9; ++ix)
                {
                    sasiedzi[iy, ix] = new HashSet<Pozycja>();
                    for (int i = 0; i < 9; ++i)
                    {
                        sasiedzi[iy, ix].Add(new Pozycja(i, iy));
                        sasiedzi[iy, ix].Add(new Pozycja(ix, i));
                    }

                    int startowyXKwadratu = (ix / 3) * 3;
                    int startowyYKwadratu = (iy / 3) * 3;

                    for (int i = startowyXKwadratu; i < startowyXKwadratu + 3; ++i)
                        for (int j = startowyYKwadratu; j < startowyYKwadratu + 3; ++j)
                            sasiedzi[iy, ix].Add(new Pozycja(i, j));
                }
        }

        static readonly List<int> mozliweWartosci = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        static readonly List<int> mozliweWartosciOdwrotnie = new List<int>(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 });

        public static bool CzyJednoRozwiazanie(ref int[,] polaSudoku)
        {
            int[,] rozwiazanieOd1 = new int[9, 9];
            int[,] rozwiazanieOd9 = new int[9, 9];

            int[,] plansza = new int[9, 9];
            for (int i = 0; i < 9; ++i)
                for (int j = 0; j < 9; ++j)
                    rozwiazanieOd1[i, j] = rozwiazanieOd9[i, j] = polaSudoku[i, j];

            Rozwiaz(ref rozwiazanieOd1);
            Rozwiaz(ref rozwiazanieOd9, true);

            for (int i = 0; i < 9; ++i)
                for (int j = 0; j < 9; ++j)
                {
                    if (rozwiazanieOd1[i, j] != rozwiazanieOd9[i, j])
                        return false;
                }
            return true;
        }

        public static void Rozwiaz(ref int[,] planszaSudoku, bool wTyl = false)
        {
            x = y = 0;
            listaPol = new LinkedList<int>();
            int ilePustych = 0;
            foreach (var item in planszaSudoku)
            {
                if (item == 0)
                    ++ilePustych;
            }
            if (ilePustych == 0)
                return;
            for (int i = 0; i < 9; ++i)
                for (int j = 0; j < 9; ++j)
                    listaPol.AddLast(planszaSudoku[i, j]);

            Uzupelnij(ref planszaSudoku, wTyl);
        }

        private static bool Uzupelnij(ref int[,] polaSudoku, bool wTyl = false)
        {
            var pole = listaPol.First;
            listaPol.RemoveFirst();
            ++x;
            if (x > 8)
            {
                ++y;
                x -= 9;
            }
            if (y > 8)
                return true;
            if (pole.Value == 0)
                {
                HashSet<int> wartosciSasiadow = new HashSet<int>();
                List<int> opcje;

                foreach (var sasiad in sasiedzi[y, x])
                {
                    var wartosc = polaSudoku[sasiad.Y, sasiad.X];
                    if (wartosc != 0)
                        wartosciSasiadow.Add(wartosc);
                }

                var mozliwe = wTyl ? mozliweWartosciOdwrotnie : mozliweWartosci;

                opcje = new List<int>(mozliwe.Except(wartosciSasiadow));
                opcje.Shuffle();

                foreach (var opcja in opcje)
                {
                    pole.Value = opcja;
                    if (listaPol.Count == 0)
                        return true;
                    if (Uzupelnij(ref polaSudoku))
                    {
                        return true;
                    }
                }

                pole.Value = 0;
                listaPol.AddFirst(pole);
                --x;
                if (x < 0)
                {
                    --y;
                    x += 9;
                }
                return false;
            }
            else
            {
                if (listaPol.Count == 0)
                    return true;
                if (Uzupelnij(ref polaSudoku))
                    return true;
                listaPol.AddFirst(pole);
                return false;
            }
        }
        public static void WymazujPola(PoleSudoku[,] polaSudoku)
        {
            bool czyJedno;
            int[,] tabelka = new int[9, 9];
            int niezapominajka = 0;
            Pozycja pozycjaDoPamietania;
            Random rand = new Random();
            List<Pozycja> zajete = new List<Pozycja>();
            for (int i = 0; i < 9; ++i)
                for (int j = 0; j < 9; ++j)
                {
                    tabelka[i, j] = polaSudoku[i, j].WartoscPola;
                    zajete.Add(new Pozycja(j, i));
                }
            int ile, usunieto = 0;
            Trudnosc trudnosc = Trudnosc.Srednie;
            switch (Properties.Settings.Default.Trudnosc)
            {
                case "Łatwa":
                    trudnosc = Trudnosc.Latwe;
                    break;
                case "Średnia":
                    trudnosc = Trudnosc.Srednie;
                    break;
                case "Trudna":
                    trudnosc = Trudnosc.Trudne;
                    break;
            }

            switch (trudnosc)
            {
                case Trudnosc.Latwe:
                    ile = 40;
                    break;
                case Trudnosc.Srednie:
                    ile = 45;
                    break;
                case Trudnosc.Trudne:
                    ile = 50;
                    break;
                default:
                    ile = 40;
                    break;
            }
            do
            {
                int pos = rand.Next(zajete.Count);
                pozycjaDoPamietania = zajete[pos];
                zajete.RemoveAt(pos);
                niezapominajka = tabelka[pozycjaDoPamietania.Y, pozycjaDoPamietania.X];
                tabelka[pozycjaDoPamietania.Y, pozycjaDoPamietania.X] = 0;
                --ile;
                ++usunieto;
                czyJedno = CzyJednoRozwiazanie(ref tabelka);
            } while (ile > 0 && czyJedno);

            if (!czyJedno)
            {
                tabelka[pozycjaDoPamietania.Y, pozycjaDoPamietania.X] = niezapominajka;
                ++ile;
                --usunieto;
            }
            System.Windows.Forms.MessageBox.Show("Usunieto " + usunieto + " pól.");

            for (int i = 0; i < 9; ++i)
                for (int j = 0; j < 9; ++j)
                    if (tabelka[i,j] == 0)
                        polaSudoku[i, j].OczyscPole();
        }
    }
}
