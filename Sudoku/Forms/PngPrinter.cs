using Sudoku.Properties;
using SudokuLib.Core;
using System.Diagnostics;
using System.IO;

namespace Sudoku
{
    public class PngPrinter : ISudokuPrinter
    {
        private const string OpenVerb = "Open";
        private const string PrintVerb = "Print";

        public void Save(int[,] board, bool[,] isPredefinedCell)
        {
            var painter = new Painter()
            {
                CellSize = Settings.Default.PrintedCellSize,
                FontSize = Settings.Default.PrintedFontSize,
                LineWidth = Settings.Default.PrintedLineWidth
            };
            var img = painter.CreateImage(board, isPredefinedCell);
            img.Save(Settings.Default.ImageDestination, System.Drawing.Imaging.ImageFormat.Png);
            Process openFileProcess = new Process();
            openFileProcess.StartInfo.FileName = Settings.Default.ImageDestination;
            openFileProcess.StartInfo.Verb = OpenVerb;
            openFileProcess.Start();
        }

        public void Print()
        {
            if (File.Exists(Settings.Default.ImageDestination))
            {
                Process printProcess = new Process();
                printProcess.StartInfo.FileName = Settings.Default.ImageDestination;
                printProcess.StartInfo.Verb = PrintVerb;
                printProcess.Start();
                return;
            }
            _ = WarningBox.ShowWithOK("File not found. You should save to PNG first.", "Attention");
        }
    }
}
