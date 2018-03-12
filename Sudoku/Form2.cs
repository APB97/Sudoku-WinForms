﻿using System;
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
        Random randoms = new Random();
        PoleSudoku[,] tabelkaSudoku = new PoleSudoku[9, 9];
        LinkedList<PoleSudoku> listaPol = new LinkedList<PoleSudoku>();
        List<int> mozliweWartosci = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

        int[] tabelaPrzesuniecH = new int[9] { 0, 1, 2, 0, 1, 2, 0, 1, 2 };
        int[] tabelaPrzesuniecV = new int[9] { 0, 0, 0, 1, 1, 1, 2, 2, 2 };

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StworzPolaSudoku();
            for (int i = 0; i < 9; ++i)
                for (int j = 0; j < 9; ++j)
                    listaPol.AddLast(tabelkaSudoku[i, j]);
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
                    var pole = new PoleSudoku()
                    {
                        X = tabelaPrzesuniecH[j] + tabelaPrzesuniecH[i] * 3,
                        Y = tabelaPrzesuniecV[j] + tabelaPrzesuniecV[i] * 3
                    };
                    obecnyKwadrat.Controls.Add(pole);
                    tabelkaSudoku[tabelaPrzesuniecV[j] + tabelaPrzesuniecV[i] * 3,
                        tabelaPrzesuniecH[j] + tabelaPrzesuniecH[i] * 3] = pole;
                    pole.textBox.PreviewKeyDown += textBoxSudoku_PreviewKeyDown;
                    //tabelkaSudoku[(i - i % 3) + (j / 3), (i % 3) * 3 + (j % 3)] = pole;
                    //tabelkaSudoku[(i - 1) / 3 * 3 + (j - 1) /3, ((i - 1) % 3) * 3 + (j - 1) % 3] = pole;
                }
            }
        }
        /// <summary>
        /// TODO: Make it working.
        /// </summary>
        private bool GenerujSudoku()
        {
            var pole = listaPol.First;
            listaPol.RemoveFirst();

            HashSet<int> wartosciSasiadow = new HashSet<int>();
            List<int> opcje;

            foreach (var sasiad in pole.Value.sasiedzi)
            {
                var wartosc = tabelkaSudoku[sasiad.Y, sasiad.X].WartoscPola;
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
                if (GenerujSudoku())
                {
                    return true;
                }
            }

            pole.Value.WartoscPola = 0;
            listaPol.AddFirst(pole);
            return false;
        }
        
        private void buttonZapiszStan_Click(object sender, EventArgs e)
        {
            MenedzerZapisuOdczytu.Zapisz(tabelkaSudoku, saveSudokuDialog);
        }

        private void buttonWczytajStan_Click(object sender, EventArgs e)
        {
            MenedzerZapisuOdczytu.Wczytaj(tabelkaSudoku, openSudokuDialog);
        }

        private void textBoxSudoku_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            var pole = (sender as Control).Parent as PoleSudoku;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (pole.X > 0)
                        pole = tabelkaSudoku[pole.Y, pole.X - 1];
                    break;
                case Keys.Right:
                    if (pole.X < 8)
                        pole = tabelkaSudoku[pole.Y, pole.X + 1];
                    break;
                case Keys.Up:
                    if (pole.Y > 0)
                        pole = tabelkaSudoku[pole.Y - 1, pole.X];
                    break;
                case Keys.Down:
                    if (pole.Y < 8)
                        pole = tabelkaSudoku[pole.Y + 1, pole.X];
                    break;
                default:
                    return;
            }
            pole.textBox.Focus();
        }
    }
}
