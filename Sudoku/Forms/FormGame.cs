using SudokuLib.Core;
using SudokuLib.OptionOrder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class FormGame : Form
    {
        public static FormGame oknoGry;

        internal SudokuCell[,] SudokuTable = new SudokuCell[9, 9];
        readonly List<int> possibleValues = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        readonly int[] HorizontalDisplacement = new int[9] { 0, 1, 2, 0, 1, 2, 0, 1, 2 };
        readonly int[] VerticalDisplacement = new int[9] { 0, 0, 0, 1, 1, 1, 2, 2, 2 };

        int[,] board = new int[9, 9];
        bool[,] isPredifinedCell = new bool[9, 9];

        public int[,] Board => board;

        public FormGame(bool createNewGame = true)
        {
            oknoGry = this;
            InitializeComponent();
            StworzPolaSudoku();

            if (createNewGame)
                CreateNewGame();
            else
                MenedzerZapisuOdczytu.Wczytaj(SudokuTable, openSudokuDialog);
        }

        private void StworzPolaSudoku()
        {
            TableLayoutPanel currentSquare;
            for (int i = 0; i < 9; ++i)
            {
                currentSquare = tableLayoutPanelPlansza.Controls.Find("tableLayoutPanel" + i, false)[0]
                    as TableLayoutPanel;
                currentSquare.TabIndex = i;
                for (int j = 0; j < 9; ++j)
                {
                    var pole = new SudokuCell(HorizontalDisplacement[j] + HorizontalDisplacement[i] * 3, VerticalDisplacement[j] + VerticalDisplacement[i] * 3);
                    currentSquare.Controls.Add(pole);
                    SudokuTable[VerticalDisplacement[j] + VerticalDisplacement[i] * 3,
                        HorizontalDisplacement[j] + HorizontalDisplacement[i] * 3] = pole;
                    pole.textBox.PreviewKeyDown += textBoxSudoku_PreviewKeyDown;
                    pole.textBox.ForeColor = Color.DimGray;
                }
            }
        }

        private void CreateNewGame()
        {
            int[,] emptyBoard = new int[9,9];
            Solver solver = new Solver() { Orderer = new OptionRandomizedOrderer<int>() };
            int[,] solvedBoard = solver.Solve(emptyBoard);
            int[,] blankedBoard = SudokuBlanker.MakeBlanks(solvedBoard, 35);
            board = blankedBoard;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    bool emptied = blankedBoard[i, j] != 0;
                    isPredifinedCell[i, j] = !emptied;
                    if (emptied)
                    {
                        SudokuTable[i, j].InitAsPredefined(blankedBoard[i, j]);
                    }
                }
            }
            MessageBox.Show(Validator.IsValidBoard(blankedBoard) ? "Board OK" : "Board NIE OK");
        }

        private void buttonZapiszStan_Click(object sender, EventArgs e)
        {
            if (saveSudokuDialog.ShowDialog() == DialogResult.OK)
            {
                SudokuSaveLoad.Save(saveSudokuDialog.FileName, board, isPredifinedCell);
            }
        }

        private void buttonWczytajStan_Click(object sender, EventArgs e)
        {
            if (openSudokuDialog.ShowDialog() == DialogResult.OK)
            {
                var (values, predefined) = SudokuSaveLoad.Load(openSudokuDialog.FileName);
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (predefined[i, j])
                        {
                            SudokuTable[i, j].InitAsPredefined(values[i, j]);
                        }
                        else
                        {
                            SudokuTable[i, j].CellValue = values[i, j];
                        }

                    }
                }
            }
        }

        private void textBoxSudoku_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            var pole = (sender as Control).Parent as SudokuCell;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (pole.X > 0)
                        pole = SudokuTable[pole.Y, pole.X - 1];
                    break;
                case Keys.Right:
                    if (pole.X < 8)
                        pole = SudokuTable[pole.Y, pole.X + 1];
                    break;
                case Keys.Up:
                    if (pole.Y > 0)
                        pole = SudokuTable[pole.Y - 1, pole.X];
                    break;
                case Keys.Down:
                    if (pole.Y < 8)
                        pole = SudokuTable[pole.Y + 1, pole.X];
                    break;
                default:
                    return;
            }
            pole.textBox.Focus();
        }

        private void button_DoMenu_Click(object sender, EventArgs e)
        {
            FormMenu.glowneOknoMenu.Show();
            Close();
        }

        private void buttonRozwiaz_Click(object sender, EventArgs e)
        {
            Solver solver = new Solver { Orderer = new NoOptionOrderer<int>() };
            var solution = solver.Solve(board);
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!SudokuTable[i,j].textBox.ReadOnly)
                    {
                        SudokuTable[i, j].CellValue = solution[i, j];
                    }
                }
            }
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
            int suppportsRemaining = int.Parse(labelPozostaloPomocy.Text);
            if (suppportsRemaining >= 1)
                if (Wspomoz())
                {
                    suppportsRemaining--;
                    labelPozostaloPomocy.Text = suppportsRemaining.ToString();
                }
        }

        private bool Wspomoz()
        {
            foreach (var pole in SudokuTable)
                if (!pole.textBox.Font.Bold)
                {
                    HashSet<int> neigborValues = new HashSet<int>();
                    List<int> options;

                    foreach (var sasiad in pole.neighbors)
                    {
                        var wartosc = SudokuTable[sasiad.Y, sasiad.X].CellValue;
                        if (wartosc != 0)
                            neigborValues.Add(wartosc);
                    }

                    options = new List<int>(possibleValues.Except(neigborValues));
                    if (options.Count == 1)
                    {
                        pole.CellValue = options[0];
                        pole.CellContent = options[0].ToString();
                        return true;
                    }
                }
            return false;
        }

        private void buttonDrukuj_Click(object sender, EventArgs e)
        {
            var painter = new Painter() { CellSize = 100, FontSize = 24, LineWidth = 2 };
            var img = painter.CreateImage(board, isPredifinedCell);
            img.Save("last.png", System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
