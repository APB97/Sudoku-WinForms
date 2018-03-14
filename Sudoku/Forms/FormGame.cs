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
    public partial class FormGame : Form
    {
        public static FormGame oknoGry;

        PoleSudoku[,] tabelkaSudoku = new PoleSudoku[9, 9];//pozwala odnieść się do pola na okreslonej pozycji
        LinkedList<PoleSudoku> listaPol = new LinkedList<PoleSudoku>();//wykorzystywana podczas generowania wypełnionego Sudoku
        readonly List<int> mozliweWartosci = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });//lista wartości używanych w Sudoku

        int[] PrzesuniecieH = new int[9] { 0, 1, 2, 0, 1, 2, 0, 1, 2 };
        int[] PrzesuniecieV = new int[9] { 0, 0, 0, 1, 1, 1, 2, 2, 2 };

        public FormGame(bool createNewGame = true)
        {
            oknoGry = this;
            this.BackColor = FormOpcje.kolorOkna;

            InitializeComponent();
            StworzPolaSudoku();

            if (createNewGame)
            {
                PrzygotujListePol();
                GenerujSudoku();
                WypelnijPlansze();
                if (Walidator.SprawdzCalaTablice(tabelkaSudoku))
                    MessageBox.Show("Plansza OK");
                else
                    MessageBox.Show("Plansza nie OK");
            }
            else
            {
                MenedzerZapisuOdczytu.Wczytaj(tabelkaSudoku, openSudokuDialog);
            }
        }

        /*private void WymazCzesc()
        {
            Random rng = new Random();
            Trudnosc trudnosc = Trudnosc.Srednie;
            int polaDoWymazania;
            switch (trudnosc)
            {
                case Trudnosc.Latwe:
                    polaDoWymazania = 35;
                    break;
                case Trudnosc.Srednie:
                    polaDoWymazania = 40;
                    break;
                case Trudnosc.Trudne:
                    polaDoWymazania = 45;
                    break;
                default:
                    polaDoWymazania = 40;
                    break;
            }

            var wartosciEnum = Enum.GetValues(typeof(TypWymazaniaPola));
            TypWymazaniaPola jakiTypWymazania = (TypWymazaniaPola) wartosciEnum.GetValue(rng.Next(wartosciEnum.Length));
            //PrzygotujListePol();
        }*/

        /// <summary>
        /// Tworzy kontrolki o odpowiednich parametrach na planszy Sudoku i zapisuje w tablicy ich referencje.
        /// </summary>
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
                    var pole = new PoleSudoku(PrzesuniecieH[j] + PrzesuniecieH[i] * 3, PrzesuniecieV[j] + PrzesuniecieV[i] * 3);
                    obecnyKwadrat.Controls.Add(pole);
                    tabelkaSudoku[PrzesuniecieV[j] + PrzesuniecieV[i] * 3,
                        PrzesuniecieH[j] + PrzesuniecieH[i] * 3] = pole;
                    pole.textBox.PreviewKeyDown += textBoxSudoku_PreviewKeyDown;
                    pole.textBox.ForeColor = Color.DimGray;
                }
            }
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
        
        private void WypelnijPlansze()
        {
            foreach (var pole in tabelkaSudoku)
            {
                pole.InicjujPole();
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
            else
                Application.Exit();
        }

        private void buttonPomoz_Click(object sender, EventArgs e)
        {
            /*int pozostalePomoce = int.Parse(labelPozostaloPomocy.Text);
            if (pozostalePomoce > 1)
            {
                Wspomoz();
                pozostalePomoce;
            }*/
        }

        private bool Wspomoz()
        {
            foreach (var pole in tabelkaSudoku)
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

                    return true;
                }
            }
            return false;
        }
    }
}
