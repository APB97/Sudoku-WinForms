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
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < rozmiar; ++i)
                {
                    for (int j = 0; j < rozmiar; ++j)
                    {
                        var zawartosc = polaSudoku[i, j].ZawartoscPola;
                        zawartosc = string.IsNullOrEmpty(zawartosc) ? "0" : zawartosc;
                        builder.Append(zawartosc + " ");
                    }
                    builder.Remove(builder.Length - 1, 1);
                    builder.AppendLine();
                }
                int newLineSize = Environment.NewLine.Length;
                builder.Remove(builder.Length - newLineSize, newLineSize);
                File.WriteAllText(saveFileDialog.FileName, builder.ToString());
            }
        }

        public static void Wczytaj(PoleSudoku[,] polaSudoku, OpenFileDialog openFileDialog)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var zawartoscPliku = File.ReadAllLines(openFileDialog.FileName);
                if (zawartoscPliku.Length != 9)
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
                        polaSudoku[i, j].ZawartoscPola = zawartoscLinii[j] == "0" ? string.Empty : zawartoscLinii[j];
                        if (zawartoscLinii[j] != "0")
                        {
                            polaSudoku[i, j].textBox.Font = new System.Drawing.Font(polaSudoku[i, j].textBox.Font, System.Drawing.FontStyle.Bold);
                            polaSudoku[i, j].textBox.ForeColor = Color.Black;
                            polaSudoku[i, j].textBox.ReadOnly = true;
                            polaSudoku[i, j].WartoscPola = int.Parse(zawartoscLinii[j]);
                        }
                        else
                        {
                            polaSudoku[i, j].WartoscPola = 0;
                            polaSudoku[i, j].textBox.ForeColor = Color.DimGray;
                            polaSudoku[i, j].textBox.ReadOnly = false;
                        }
                    }
                }
            }
            /*if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var zawartoscPliku = File.ReadAllLines(openFileDialog.FileName);
                if (zawartoscPliku.Length != 9)
                {
                    WarningBoxes.ShowWithOK(Jezyk.Komunikaty.NieodpowiedniaIloscLinii, Jezyk.Komunikaty.Uwaga);
                    return;
                }
                for (int i = 0; i < 9; ++i)
                {
                    var zawartoscLinii = zawartoscPliku[i].Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
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
                        polaSudoku[i, j].ZawartoscPola = zawartoscLinii[j] == "0" ? string.Empty: zawartoscLinii[j];
                    }
                }
            }*/
        }
    }
}
