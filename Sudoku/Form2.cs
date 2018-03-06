using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form2 : Form
    {
        PoleSudoku[,] tabelkaSudoku = new PoleSudoku[9,9];

        int[] tabelaPrzesuniecH = new int[9] { 0, 1, 2, 0, 1, 2, 0, 1, 2 };
        int[] tabelaPrzesuniecV = new int[9] { 0, 0, 0, 1, 1, 1, 2, 2, 2 };

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StworzPolaSudoku();
            GenerujSudoku();
        }

        private void StworzPolaSudoku()
        {
            Control obecnyKwadratCtrl;
            TableLayoutPanel obecnyKwadrat;
            for (int i = 0; i < 9; ++i)
            {
                obecnyKwadratCtrl = tableLayoutPanelPlansza.Controls.Find("tableLayoutPanel" + i, false)[0];
                obecnyKwadratCtrl.TabIndex = i;
                obecnyKwadrat = obecnyKwadratCtrl as TableLayoutPanel;
                for (int j = 0; j < 9; ++j)
                {
                    var pole = new PoleSudoku();
                    obecnyKwadrat.Controls.Add(pole);
                    tabelkaSudoku[tabelaPrzesuniecV[j] + tabelaPrzesuniecV[i] * 3,
                        tabelaPrzesuniecH[j] + tabelaPrzesuniecH[i] * 3] = pole;
                    //tabelkaSudoku[(i - i % 3) + (j / 3), (i % 3) * 3 + (j % 3)] = pole;
                    //tabelkaSudoku[(i - 1) / 3 * 3 + (j - 1) /3, ((i - 1) % 3) * 3 + (j - 1) % 3] = pole;
                }
            }
        }
        /*
        private void GenerujSudoku()
        {
            int nowa;
            int[,] plansza = new int[9, 9];
            List<int>[,] juzUzyte = new List<int>[9, 9];
            for (int i = 0; i < 9; ++i)
                for (int j = 0; j < 9; ++j)
                    juzUzyte[i, j] = new List<int>();
            List<int>[] dostepneWKwadracie = new List<int>[9];
            for (int i = 0; i < 9; ++i)
                dostepneWKwadracie[i] = new List<int>(Enumerable.Range(1, 9));
            Random generatorLiczb = new Random();
            List<int> dostepneWartosci = new List<int>(Enumerable.Range(1, 9));
            for (int i = 0; i < 9; ++i)
            {
                nowa = dostepneWartosci[generatorLiczb.Next(0, dostepneWartosci.Count)];
                dostepneWartosci.Remove(nowa);
                plansza[0, i] = nowa;
                dostepneWKwadracie[i / 3].Remove(nowa);
                juzUzyte[0, i].Add(nowa);
            }
            int v = 1, h = 0;
            while (v < 9)
            {
                dostepneWartosci = new List<int>(Enumerable.Range(1, 9));
                for (int j = 0; j < 9; ++j)
                {
                    dostepneWartosci.Remove(plansza[j, h]);
                    dostepneWartosci.Remove(plansza[v, j]);
                }
                foreach(int number in Enumerable.Range(1, 9).Except(dostepneWKwadracie[v / 3 * 3 + h / 3]))
                {
                    dostepneWartosci.Remove(number);
                }
                foreach(int number in juzUzyte[v, h])
                {
                    dostepneWartosci.Remove(number);
                }

                if (dostepneWartosci.Count > 0)
                {
                    nowa = dostepneWartosci[generatorLiczb.Next(0, dostepneWartosci.Count)];
                    plansza[v, h] = nowa;
                    dostepneWKwadracie[v / 3 * 3 + h / 3].Remove(nowa);
                    juzUzyte[v, h].Add(nowa);
                }
                else
                {
                    juzUzyte[v, h].Clear();
                    if (plansza[v, h] != 0)
                        dostepneWKwadracie[v / 3 * 3 + h / 3].Add(plansza[v, h]);
                    plansza[v, h] = 0;
                    --h;
                    if (h < 0)
                    {
                        --v;
                        h += 9;
                    }
                    continue;
                }

                ++h;
                if (h >= 9)
                {
                    h -= 9;
                    v++;
                }
            }
            /*int wiersz = 0;
            int kolumna = 0;
            int nowaWartosc;
            List<int> wartosci = new List<int>(Enumerable.Range(1, 9));
            List<int> uzyteWartosci = new List<int>();
            Random generator = new Random();
            int losowyIndeks = generator.Next(0, wartosci.Count);
            nowaWartosc = wartosci[losowyIndeks];
            tabelkaSudoku[wiersz, kolumna].InicjujPole(nowaWartosc);
            wartosci.Remove(nowaWartosc);
            for (wiersz = 1; wiersz < 9; ++ wiersz)
            {
                losowyIndeks = generator.Next(0, wartosci.Count);
                nowaWartosc = wartosci[losowyIndeks];
                wartosci.Remove(nowaWartosc);
                uzyteWartosci.Add(nowaWartosc);
                tabelkaSudoku[wiersz, kolumna].InicjujPole(nowaWartosc);
            }
            wiersz = 0;
            
        }*/

        private void GenerujSudoku()
        {

        }
        
        private void buttonZapiszStan_Click(object sender, EventArgs e)
        {
            MenedzerZapisuOdczytu.Zapisz(tabelkaSudoku, saveSudokuDialog);
        }

        private void buttonWczytajStan_Click(object sender, EventArgs e)
        {
            MenedzerZapisuOdczytu.Wczytaj(tabelkaSudoku, openSudokuDialog);
        }
    }
}
