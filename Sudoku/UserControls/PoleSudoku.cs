using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class PoleSudoku : UserControl
    {
        /// <summary>
        /// Pozycja horyzontalna.
        /// </summary>
        public int X { get; set; }
        
        /// <summary>
        /// Pozycja wertykalna.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Zapewnia dostęp do zawartości tekstowej pola.
        /// </summary>
        public string ZawartoscPola
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        /// <summary>
        /// Liczbowa wartość pola.
        /// </summary>
        public int WartoscPola { get; set; } = 0;

        /// <summary>
        /// Zbiór sąsiadów.
        /// </summary>
        public HashSet<Pozycja> sasiedzi = new HashSet<Pozycja>();

        public PoleSudoku()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor używany do przypisania polu konkretnej pozycji i wyznaczenia zbioru sąsiadów.
        /// </summary>
        /// <param name="x">Pozycja w poziomie.</param>
        /// <param name="y">Pozycja w pionie.</param>
        public PoleSudoku(int x, int y)
        {
            InitializeComponent();
            X = x; Y = y;
            DodajSasiadow();
        }

        /// <summary>
        /// Metoda wyznaczająca i zapisująca sąsiadów danego pola.
        /// </summary>
        private void DodajSasiadow()
        {
            for (int i = 0; i < 9; ++i)
            {
                sasiedzi.Add(new Pozycja(i, Y));
                sasiedzi.Add(new Pozycja(X, i));
            }

            int startowyXKwadratu = (X / 3) * 3;
            int startowyYKwadratu = (Y / 3) * 3;

            for (int i = startowyXKwadratu; i < startowyXKwadratu + 3; ++i)
                for (int j = startowyYKwadratu; j < startowyYKwadratu + 3; ++j)
                    sasiedzi.Add(new Pozycja(i, j));
        }

        /// <summary>
        /// Inicjuje pole jako stały element zagadki.
        /// </summary>
        /// <param name="wartosc">Gdy null, używa WartosciPola do inicjowania pola tekstowego. W przeciwnym przypadku, używa podanego argumentu.</param>
        public void InicjujPoleJakoNiezmienne(int? wartosc = null)
        {
            textBox.ForeColor = Color.Black;
            textBox.Font = new Font(textBox.Font, FontStyle.Bold);
            if (wartosc == null)
                textBox.Text = WartoscPola.ToString();
            else
            {
                textBox.Text = wartosc.Value.ToString();
                WartoscPola = wartosc.Value;
            }
            textBox.ReadOnly = true;
        }

        /// <summary>
        /// Modyfikuje własności pola, w tym kolor i czcionkę, aby była możliwa jego edycja.
        /// </summary>
        /// <param name="tekst">Pozwala ustawić tekst w oczyszczonym polu.</param>
        public void OczyscPole(string tekst = "0")
        {
            this.WartoscPola = int.Parse(tekst);
            textBox.ReadOnly = false;
            this.ZawartoscPola = tekst == "0" ? string.Empty : tekst;
            textBox.ForeColor = Color.DimGray;
            textBox.Font = new Font(textBox.Font, FontStyle.Regular);
        }

        /// <summary>
        /// Bazowe blokowanie wprowadzania niepoprawnych danych.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0 && (!char.IsDigit(textBox.Text[0]) || textBox.Text[0] == '0'))
            {
                ZawartoscPola = string.Empty;
                return;
            }
        }

        /// <summary>
        /// Blokuje cyfry, które nie mogą zostać wpisane zgodnie z zasadami Sudoku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            string key = e.KeyCode.ToString();
            if (key.Length != 2 || key[0] != 'D')
                return;
            if (!char.IsDigit(key[1]) || key[1] == '0')
                return;

            WartoscPola = int.Parse(key[1].ToString());
            if (Walidator.SprawdzPole(FormGame.oknoGry.tabelkaSudoku, new Pozycja(X, Y)))
            {
                ZawartoscPola = WartoscPola.ToString();
            }
            else
            {
                WartoscPola = 0;
                ZawartoscPola = string.Empty;
            }
            e.SuppressKeyPress = true;
        }
    }
}
