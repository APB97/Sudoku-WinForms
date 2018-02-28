using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
                    MessageBox.Show("Nieodpowiednia ilość linii w pliku!", "Uwaga!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                for (int i = 0; i < 9; ++i)
                {
                    var zawartoscLinii = zawartoscPliku[i].Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
                    if (zawartoscLinii.Length != 9)
                    {
                        MessageBox.Show(string.Format("Nieodpowiednia ilość wartości pól w linii {0}!", i), "Uwaga!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (zawartoscLinii.Any((string s) => !char.IsDigit(s[0]) || s.Length > 1))
                    {
                        MessageBox.Show(string.Format("W linii {0} nie wszystkie wartości pól są cyframi!"), "Uwaga!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    for (int j = 0; j < 9; ++j)
                    {
                        polaSudoku[i, j].ZawartoscPola = zawartoscLinii[j] == "0" ? "": zawartoscLinii[j];
                    }
                }
            }
        }
    }
}
