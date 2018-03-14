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
        public static void Zapisz(PoleSudoku[,] polaSudoku, SaveFileDialog saveFileDialog)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                int rozmiar = polaSudoku.GetLength(0);
                StringBuilder puzzleBuilder = new StringBuilder();
                StringBuilder gameStateBuilder = new StringBuilder();
                for (int i = 0; i < rozmiar; ++i)
                {
                    for (int j = 0; j < rozmiar; ++j)
                    {
                        var zawartosc = polaSudoku[i, j].ZawartoscPola;
                        zawartosc = string.IsNullOrEmpty(zawartosc) ? "0" : zawartosc;
                        if (polaSudoku[i, j].textBox.Font.Bold)
                        {
                            puzzleBuilder.Append(zawartosc + " ");
                            gameStateBuilder.Append("0 ");
                        }
                        else
                        {
                            gameStateBuilder.Append(zawartosc + " ");
                            puzzleBuilder.Append("0 ");
                        }
                    }
                    puzzleBuilder.Remove(puzzleBuilder.Length - 1, 1);
                    gameStateBuilder.Remove(gameStateBuilder.Length - 1, 1);
                    puzzleBuilder.AppendLine();
                    gameStateBuilder.AppendLine();
                }
                int newLineSize = Environment.NewLine.Length;
                puzzleBuilder.Remove(puzzleBuilder.Length - newLineSize, newLineSize);
                gameStateBuilder.Remove(gameStateBuilder.Length - newLineSize, newLineSize);
                File.WriteAllText(saveFileDialog.FileName, puzzleBuilder.ToString() + Environment.NewLine + Environment.NewLine +
                    gameStateBuilder.ToString());
            }
        }

        public static void Wczytaj(PoleSudoku[,] polaSudoku, OpenFileDialog openFileDialog)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var zawartoscPliku = File.ReadAllLines(openFileDialog.FileName);
                zawartoscPliku = zawartoscPliku.Where((string s) =>
                {
                    return !string.IsNullOrWhiteSpace(s);
                }).ToArray();

                if (zawartoscPliku.Length != 18)
                {
                    WarningBoxes.ShowWithOK(Jezyk.Komunikaty.NieodpowiedniaIloscLinii, Jezyk.Komunikaty.Uwaga);
                    return;
                }
                for (int i = 0; i < 9; ++i)
                {
                    var zawartoscLinii = zawartoscPliku[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (zawartoscLinii.Length != 9)
                    {
                        WarningBoxes.ShowWithOK(Jezyk.Komunikaty.NieodpowiedniaIloscWartosciPol(i),
                            Jezyk.Komunikaty.Uwaga);
                        return;
                    }
                    if (zawartoscLinii.Any((string s) => !char.IsDigit(s[0]) || s.Length > 1))
                    {
                        WarningBoxes.ShowWithOK(Jezyk.Komunikaty.NieWszystkieSaCyframi(i), Jezyk.Komunikaty.Uwaga);
                        return;
                    }
                    for (int j = 0; j < 9; ++j)
                    {
                        if (zawartoscLinii[j] != "0")
                        {
                            polaSudoku[i, j].textBox.Font = new System.Drawing.Font(polaSudoku[i, j].textBox.Font, System.Drawing.FontStyle.Bold);
                            polaSudoku[i, j].textBox.ForeColor = Color.Black;
                            polaSudoku[i, j].textBox.ReadOnly = true;
                            polaSudoku[i, j].WartoscPola = int.Parse(zawartoscLinii[j]);
                        }
                        /*else
                        {
                            polaSudoku[i, j].WartoscPola = 0;
                            polaSudoku[i, j].textBox.ForeColor = Color.DimGray;
                            polaSudoku[i, j].textBox.ReadOnly = false;
                        }*/
                    }
                }

                for (int i = 9; i < 18; ++i)
                {
                    int indeksWTablicy = i - 9;
                    var zawartoscLinii = zawartoscPliku[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (zawartoscLinii.Length != 9)
                    {
                        WarningBoxes.ShowWithOK(Jezyk.Komunikaty.NieodpowiedniaIloscWartosciPol(i),
                            Jezyk.Komunikaty.Uwaga);
                        return;
                    }
                    if (zawartoscLinii.Any((string s) => !char.IsDigit(s[0]) || s.Length > 1))
                    {
                        WarningBoxes.ShowWithOK(Jezyk.Komunikaty.NieWszystkieSaCyframi(i), Jezyk.Komunikaty.Uwaga);
                        return;
                    }
                    for (int j = 0; j < 9; ++j)
                    {
                        if (zawartoscLinii[j] != "0")
                        {
                            polaSudoku[indeksWTablicy , j].textBox.Font = new Font(polaSudoku[indeksWTablicy, j].textBox.Font, FontStyle.Regular);
                            polaSudoku[indeksWTablicy, j].textBox.ForeColor = Color.DimGray;
                            polaSudoku[indeksWTablicy, j].textBox.ReadOnly = false;
                            polaSudoku[indeksWTablicy, j].WartoscPola = int.Parse(zawartoscLinii[j]);
                        }
                    }
                }

                if (Walidator.SprawdzCalaTablice(polaSudoku))
                {
                    MessageBox.Show("OK");
                    foreach (var item in polaSudoku)
                    {
                        item.ZawartoscPola = (item.WartoscPola == 0) ? string.Empty : item.WartoscPola.ToString();
                    }
                }
                else
                    MessageBox.Show("NIE OK");
            }
        }
    }
}
