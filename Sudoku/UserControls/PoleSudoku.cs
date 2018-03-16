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
        /// Konstruktor używany do przypisania polu konkretnej pozycji i wyznaczeniu zbioru sąsiadów.
        /// </summary>
        /// <param name="x">Pozycja w poziomie.</param>
        /// <param name="y">Pozycja w pionie.</param>
        public PoleSudoku(int x, int y)
        {
            InitializeComponent();
            X = x; Y = y;
            DodajSasiadow();
        }

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

        public void OczyscPole(string tekst = "0")
        {
            this.WartoscPola = int.Parse(tekst);
            textBox.ReadOnly = false;
            this.ZawartoscPola = tekst == "0" ? string.Empty : tekst;
            textBox.ForeColor = Color.DimGray;
            textBox.Font = new Font(textBox.Font, FontStyle.Regular);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0 && (!char.IsDigit(textBox.Text[0]) || textBox.Text[0] == '0'))
                textBox.Text = string.Empty;
        }
    }
}
