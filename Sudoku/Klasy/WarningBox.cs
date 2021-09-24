using System.Windows.Forms;

namespace Sudoku
{
    class WarningBox
    {
        public static DialogResult ShowWithOK(string trescKomunikatu, string tytulKomunikatu) =>
            MessageBox.Show(trescKomunikatu, tytulKomunikatu, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
