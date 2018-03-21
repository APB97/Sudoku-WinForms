using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class FormGame : Form
    {
        public static FormGame oknoGry;

        internal PoleSudoku[,] tabelkaSudoku = new PoleSudoku[9, 9];//pozwala odnieść się do pola na okreslonej pozycji
        LinkedList<PoleSudoku> listaPol = new LinkedList<PoleSudoku>();//wykorzystywana podczas generowania wypełnionego Sudoku
        readonly List<int> mozliweWartosci = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });//lista wartości używanych w Sudoku

        int[] PrzesuniecieH = new int[9] { 0, 1, 2, 0, 1, 2, 0, 1, 2 };
        int[] PrzesuniecieV = new int[9] { 0, 0, 0, 1, 1, 1, 2, 2, 2 };

        public FormGame(bool createNewGame = true)
        {
            oknoGry = this;
            InitializeComponent();
            StworzPolaSudoku();

            if (createNewGame)
                StworzNowaGre();
            else
                MenedzerZapisuOdczytu.Wczytaj(tabelkaSudoku, openSudokuDialog);
        }

        /// <summary>
        /// Tworzy kontrolki o odpowiednich parametrach na planszy Sudoku i zapisuje w tablicy ich referencje.
        /// </summary>
        private void StworzPolaSudoku()
        {
            TableLayoutPanel obecnyKwadrat;
            for (int i = 0; i < 9; ++i)
            {
                obecnyKwadrat = tableLayoutPanelPlansza.Controls.Find("tableLayoutPanel" + i, false)[0]
                    as TableLayoutPanel;
                obecnyKwadrat.TabIndex = i;
                for (int j = 0; j < 9; ++j)
                {
                    var pole = new PoleSudoku(PrzesuniecieH[j] + PrzesuniecieH[i] * 3, PrzesuniecieV[j] + PrzesuniecieV[i] * 3);
                    obecnyKwadrat.Controls.Add(pole);
                    tabelkaSudoku[PrzesuniecieV[j] + PrzesuniecieV[i] * 3,
                        PrzesuniecieH[j] + PrzesuniecieH[i] * 3] = pole;
                    pole.textBox.PreviewKeyDown += textBoxSudoku_PreviewKeyDown;
                    pole.textBox.ForeColor = Color.DimGray;
                }
            }
        }

        private void StworzNowaGre()
        {
            PrzygotujListePol();
            SudokuSolver.Rozwiaz(tabelkaSudoku);//"rozwiązuje" pustą planszę
            Wymazywacz.WymazujPola(tabelkaSudoku);
            WypelnijPlansze();
            if (Walidator.SprawdzCalaTablice(tabelkaSudoku))
                MessageBox.Show("Plansza OK");
            else
                MessageBox.Show("Plansza nie OK");
        }

        /// <summary>
        /// Przygotowuje listę wszystkich pól dla rekurencyjnego algorytmu generowania wypełnionej planszy.
        /// </summary>
        private void PrzygotujListePol()
        {
            for (int i = 0; i < 9; ++i)
                for (int j = 0; j < 9; ++j)
                    listaPol.AddLast(tabelkaSudoku[i, j]);
        }
        
        private void WypelnijPlansze()
        {
            foreach (var pole in tabelkaSudoku)
            {
                if (pole.WartoscPola != 0)
                    pole.InicjujPoleJakoNiezmienne();
            }
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

        private void button_DoMenu_Click(object sender, EventArgs e)
        {
            FormMenu.glowneOknoMenu.Show();
            this.Close();
        }

        private void buttonRozwiaz_Click(object sender, EventArgs e)
        {
            SudokuSolver.Rozwiaz(tabelkaSudoku);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                FormMenu.glowneOknoMenu.Show();
            else if (e.CloseReason != CloseReason.ApplicationExitCall)
                Application.Exit();
        }

        private void buttonPomoz_Click(object sender, EventArgs e)
        {
            int pozostalePomoce = int.Parse(labelPozostaloPomocy.Text);
            if (pozostalePomoce >= 1)
            {
                Wspomoz();
                pozostalePomoce--;
                labelPozostaloPomocy.Text = pozostalePomoce.ToString();
            }
        }

        private bool Wspomoz()
        {
            foreach (var pole in tabelkaSudoku)
                if (!pole.textBox.Font.Bold)
                {
                    HashSet<int> wartosciSasiadow = new HashSet<int>();
                    List<int> opcje;

                    foreach (var sasiad in pole.sasiedzi)
                    {
                        var wartosc = tabelkaSudoku[sasiad.Y, sasiad.X].WartoscPola;
                        if (wartosc != 0)
                            wartosciSasiadow.Add(wartosc);
                    }

                    opcje = new List<int>(mozliweWartosci.Except(wartosciSasiadow));
                    if (opcje.Count == 1)
                    {
                        pole.WartoscPola = opcje[0];
                        pole.ZawartoscPola = opcje[0].ToString();
                        return true;
                    }
                }
            return false;
        }

        private void buttonDrukuj_Click(object sender, EventArgs e)
        {
            new WydrukSudoku(100, 2, 2).Drukuj(tabelkaSudoku);
        }
    }
}
