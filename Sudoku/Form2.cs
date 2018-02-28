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
        }

        private void StworzPolaSudoku()
        {
            Control obecnyKwadratCtrl;
            TableLayoutPanel obecnyKwadrat;
            for (int i = 0; i < 9; ++i)
            {
                //Controls.Find()
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
