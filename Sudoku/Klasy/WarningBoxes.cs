using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    class WarningBoxes
    {
        public static DialogResult ShowWithOK(string trescKomunikatu, string tytulKomunikatu) =>
            MessageBox.Show(trescKomunikatu, tytulKomunikatu, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
