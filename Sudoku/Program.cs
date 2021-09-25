using System;
using System.Windows.Forms;

namespace Sudoku
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var printer = new PngPrinter();
            Application.Run(new FormMenu(printer));
        }
    }
}
