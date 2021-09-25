using System.Windows.Forms;

namespace Sudoku
{
    class WarningBox
    {
        public static DialogResult ShowWithOK(string content, string title) =>
            MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
