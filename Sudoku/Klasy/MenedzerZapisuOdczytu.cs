using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Sudoku
{
    static class MenedzerZapisuOdczytu
    {
        #region //Zapis planszy

        public static void Zapisz(PoleSudoku[,] polaSudoku, SaveFileDialog saveFileDialog)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder puzzleBuilder = new StringBuilder();
                StringBuilder gameStateBuilder = new StringBuilder();
                for (int i = 0; i < 9; ++i)
                {
                    for (int j = 0; j < 9; ++j)
                        ZapiszPoleWBuilderze(polaSudoku[i, j], puzzleBuilder, gameStateBuilder);
                    UsunNadmiarowaSpacje(puzzleBuilder, gameStateBuilder);
                    PrzejdzDoNowejLinii(puzzleBuilder, gameStateBuilder);
                }
                UsunNadmiarowaLinie(puzzleBuilder, gameStateBuilder);
                ZapiszWPliku(saveFileDialog.FileName, puzzleBuilder.ToString(), gameStateBuilder.ToString());
            }
        }

        private static void ZapiszPoleWBuilderze(PoleSudoku pole, StringBuilder puzzle, StringBuilder gameState)
        {
            var zawartosc = pole.ZawartoscPola;
            zawartosc = string.IsNullOrEmpty(zawartosc) ? "0" : zawartosc;
            if (pole.textBox.Font.Bold)
            {
                puzzle.Append(zawartosc + " ");
                gameState.Append("0 ");
            }
            else
            {
                gameState.Append(zawartosc + " ");
                puzzle.Append("0 ");
            }
        }

        private static void UsunNadmiarowaSpacje(StringBuilder puzzleBuilder, StringBuilder gameStateBuilder)
        {
            puzzleBuilder.Remove(puzzleBuilder.Length - 1, 1);
            gameStateBuilder.Remove(gameStateBuilder.Length - 1, 1);
        }

        private static void PrzejdzDoNowejLinii(StringBuilder puzzleBuilder, StringBuilder gameStateBuilder)
        {
            puzzleBuilder.AppendLine();
            gameStateBuilder.AppendLine();
        }

        private static void UsunNadmiarowaLinie(StringBuilder puzzleBuilder, StringBuilder gameStateBuilder)
        {
            int newLineSize = Environment.NewLine.Length;
            puzzleBuilder.Remove(puzzleBuilder.Length - newLineSize, newLineSize);
            gameStateBuilder.Remove(gameStateBuilder.Length - newLineSize, newLineSize);
        }

        private static void ZapiszWPliku(string path, string puzzle, string gameState)
        {
            File.WriteAllText(path, puzzle + Environment.NewLine + Environment.NewLine + gameState);
        }

        #endregion


        #region //Wczytywanie planszy

        public static void Wczytaj(PoleSudoku[,] polaSudoku, OpenFileDialog openFileDialog)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var zawartoscPliku = File.ReadAllLines(openFileDialog.FileName).Where((string s) =>
                {
                    return !string.IsNullOrWhiteSpace(s);
                }).ToArray();

                if (SprobujWcztacSudoku(ref zawartoscPliku, polaSudoku))
                {
                    SprobujWcztacZapisSudoku(ref zawartoscPliku, polaSudoku);
                    SprawdzWczytane(polaSudoku);

                }
            }
        }

        private static bool SprobujWcztacSudoku(ref string[] zawartoscPliku, PoleSudoku[,] polaSudoku)
        {
            if (zawartoscPliku.Length < 9)
            {
                WarningBox.ShowWithOK(Jezyk.Komunikaty.NieodpowiedniaIloscLinii, Jezyk.Komunikaty.Uwaga);
                return false;
            }
            foreach (var item in polaSudoku)
                item.OczyscPole();
            for (int i = 0; i < 9; ++i)
            {
                var zawartoscLinii = zawartoscPliku[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (zawartoscLinii.Length != 9)
                {
                    WarningBox.ShowWithOK(Jezyk.Komunikaty.NieodpowiedniaIloscWartosciPol(i),
                        Jezyk.Komunikaty.Uwaga);
                    return false;
                }
                if (zawartoscLinii.Any((string s) => !char.IsDigit(s[0]) || s.Length > 1))
                {
                    WarningBox.ShowWithOK(Jezyk.Komunikaty.NieWszystkieSaCyframi(i), Jezyk.Komunikaty.Uwaga);
                    return false;
                }
                for (int j = 0; j < 9; ++j)
                {
                    if (zawartoscLinii[j] != "0")
                        polaSudoku[i, j].InicjujPoleJakoNiezmienne(int.Parse(zawartoscLinii[j]));
                    else
                        polaSudoku[i, j].OczyscPole();
                }
            }
            return true;
        }

        private static bool SprobujWcztacZapisSudoku(ref string[] zawartoscPliku, PoleSudoku[,] polaSudoku)
        {
            if (zawartoscPliku.Length != 18)
                return false;
            for (int i = 9; i < 18; ++i)
            {
                int indeksWTablicy = i - 9;
                var zawartoscLinii = zawartoscPliku[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (zawartoscLinii.Length != 9)
                {
                    WarningBox.ShowWithOK(Jezyk.Komunikaty.NieodpowiedniaIloscWartosciPol(i),
                        Jezyk.Komunikaty.Uwaga);
                    return false;
                }
                if (zawartoscLinii.Any((string s) => !char.IsDigit(s[0]) || s.Length > 1))
                {
                    WarningBox.ShowWithOK(Jezyk.Komunikaty.NieWszystkieSaCyframi(i), Jezyk.Komunikaty.Uwaga);
                    return false;
                }
                for (int j = 0; j < 9; ++j)
                {
                    if (zawartoscLinii[j] != "0")
                    {
                        polaSudoku[indeksWTablicy, j].OczyscPole(zawartoscLinii[j]);
                    }
                }
            }
            return true;
        }

        private static void SprawdzWczytane(PoleSudoku[,] polaSudoku)
        {
            if (Walidator.SprawdzCalaTablice(polaSudoku))
                MessageBox.Show("plansza OK");
            else
            {
                foreach (var item in polaSudoku)
                {
                    item.OczyscPole();
                }
                MessageBox.Show("plansza NIE OK");
            }
        }

        #endregion
    }
}
