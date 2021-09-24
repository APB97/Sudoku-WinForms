using SudokuLib.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class SudokuCell : UserControl
    {
        public int X { get; set; }

        public int Y { get; set; }

        public string CellContent
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public int CellValue
        {
            get
            {
                if (string.IsNullOrEmpty(CellContent))
                    return 0;
                return int.Parse(textBox.Text);
            }
            set
            {
                if (value == 0)
                    textBox.Text = string.Empty;
                else
                    textBox.Text = value.ToString();
            }
        }
        public HashSet<Location> neighbors = new HashSet<Location>();

        public SudokuCell()
        {
            InitializeComponent();
        }

        public SudokuCell(int x, int y)
        {
            InitializeComponent();
            X = x;
            Y = y;
            AddNeighbors();
        }

        private void AddNeighbors()
        {
            for (int i = 0; i < 9; ++i)
            {
                neighbors.Add(new Location(i, Y));
                neighbors.Add(new Location(X, i));
            }

            int startingXofSquare = (X / 3) * 3;
            int startingYofSquare = (Y / 3) * 3;

            for (int i = startingXofSquare; i < startingXofSquare + 3; ++i)
                for (int j = startingYofSquare; j < startingYofSquare + 3; ++j)
                    neighbors.Add(new Location(i, j));
        }

        public void InitAsPredefined(int? wartosc = null)
        {
            textBox.ForeColor = Color.Black;
            textBox.Font = new Font(textBox.Font, FontStyle.Bold);
            if (wartosc == null)
                textBox.Text = CellValue.ToString();
            else
            {
                textBox.Text = wartosc.Value.ToString();
                CellValue = wartosc.Value;
            }
            textBox.ReadOnly = true;
        }

        public void CleanCell(string tekst = "0")
        {
            CellValue = int.Parse(tekst);
            textBox.ReadOnly = false;
            CellContent = tekst == "0" ? string.Empty : tekst;
            textBox.ForeColor = Color.DimGray;
            textBox.Font = new Font(textBox.Font, FontStyle.Regular);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0 && (!char.IsDigit(textBox.Text[0]) || textBox.Text[0] == '0'))
            {
                CellContent = string.Empty;
                return;
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            string key = e.KeyCode.ToString();
            if (key.Length != 2 || key[0] != 'D')
                return;
            if (!char.IsDigit(key[1]) || key[1] == '0')
                return;

            CellValue = int.Parse(key[1].ToString());
            if (!Validator.IsValid(FormGame.oknoGry.Board, (X, Y)))
            {
                CellValue = 0;
            }
            e.SuppressKeyPress = true;
        }
    }
}
