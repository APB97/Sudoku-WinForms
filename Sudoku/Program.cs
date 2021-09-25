﻿using System;
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
            var sudokuCreator = new SudokuCreator();
            var printer = new PngPrinter();
            Application.Run(new FormMenu(printer, sudokuCreator));
        }
    }
}
