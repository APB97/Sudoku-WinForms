using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class SudokuCell : UserControl, ICell
    {
        private readonly IBoard board;

        public int X { get; private set; }

        public int Y { get; private set; }

        private string CellContent => textBox.Text;

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
                {
                    textBox.Text = value.ToString();
                    textBox.ReadOnly = false;
                    textBox.ForeColor = Color.DimGray;
                    textBox.Font = new Font(textBox.Font, FontStyle.Bold);
                }
            }
        }

        public HashSet<Location> Neighbors { get; private set; } = new HashSet<Location>();

        public bool ReadOnly => textBox.ReadOnly;

        public SudokuCell()
        {
            InitializeComponent();
        }

        public SudokuCell(IBoard board, int x, int y)
        {
            InitializeComponent();
            this.board = board ?? throw new ArgumentNullException(nameof(board));
            X = x;
            Y = y;
            AddNeighbors();
        }

        private void AddNeighbors()
        {
            AddHorizontalNeighbors();
            AddVerticalNeighbors();
            AddNeighborsFromSquare(X / 3 * 3, Y / 3 * 3);
        }

        private void AddVerticalNeighbors()
        {
            for (int i = 0; i < 9; ++i)
            {
                Neighbors.Add(new Location(X, i));
            }
        }

        private void AddHorizontalNeighbors()
        {
            for (int i = 0; i < 9; ++i)
            {
                Neighbors.Add(new Location(i, Y));
            }
        }

        private void AddNeighborsFromSquare(int startingXofSquare, int startingYofSquare)
        {
            for (int x = startingXofSquare; x < startingXofSquare + 3; ++x)
            {
                for (int y = startingYofSquare; y < startingYofSquare + 3; ++y)
                {
                    Neighbors.Add(new Location(x, y));
                }
            }
        }

        public void InitAsPredefined(int value)
        {
            CellValue = value;
            textBox.ForeColor = Color.Black;
            textBox.Font = new Font(textBox.Font, FontStyle.Bold);
            textBox.ReadOnly = true;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0 && IsCharNotANonZeroDigit(textBox.Text[0]))
            {
                if (CellValue != 0)
                {
                    CellValue = 0;
                    board.EmptyCells++;
                }
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TrySettingCellValue(e);
        }

        private void TrySettingCellValue(KeyEventArgs e)
        {
            if (textBox.ReadOnly == true) 
                return;
            string key = e.KeyCode.ToString();
            if (IsNotADigitKey(key) || IsCharNotANonZeroDigit(key[1]))
                return;
            if (CellValue == 0)
            {
                board.EmptyCells--;
            }
            CellValue = int.Parse(key[1].ToString());
            if (HasInvalidValue())
            {
                CellValue = 0;
                board.EmptyCells++;
            }
            board.Board[Y, X] = CellValue;
            e.SuppressKeyPress = true;
        }

        private static bool IsNotADigitKey(string keyName)
        {
            return keyName.Length != 2 || keyName[0] != 'D';
        }

        private static bool IsCharNotANonZeroDigit(char character)
        {
            return !char.IsDigit(character) || character == '0';
        }

        private bool HasInvalidValue()
        {
            return Neighbors.Select(loc => board.Board[loc.Y, loc.X]).Any(cell => cell == CellValue);
        }

        public void FocusTextbox()
        {
            textBox.Focus();
        }
    }
}
