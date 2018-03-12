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
        public int X { get; set; }
        public int Y { get; set; }

        public string ZawartoscPola
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public int WartoscPola
        {
            get; set;
            //get { return textBox.Text == string.Empty ? 0 : int.Parse(textBox.Text); }
            //set { textBox.Text = (value == 0 ? string.Empty : value.ToString()); }
        } = 0;

        public HashSet<Pozycja> sasiedzi = new HashSet<Pozycja>();

        public PoleSudoku()
        {
            InitializeComponent();
        }

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
                //if (i != X)
                    sasiedzi.Add(new Pozycja(i, Y));
                //if (i != Y)
                    sasiedzi.Add(new Pozycja(X, i));
            }

            int startowyXKwadratu = (X / 3) * 3;
            int startowyYKwadratu = (Y / 3) * 3;

            for (int i = startowyXKwadratu; i < startowyXKwadratu + 3; ++i)
            {
                for (int j = startowyYKwadratu; j < startowyYKwadratu + 3; ++j)
                {
                    sasiedzi.Add(new Pozycja(i, j));
                }
            }
        }

        public void InicjujPole(int wartoscPola)
        {
            textBox.Font = new Font(textBox.Font, FontStyle.Bold);
            textBox.Text = wartoscPola.ToString();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0 && !char.IsDigit(textBox.Text[0]))
                textBox.Text = string.Empty;
        }
    }
}
