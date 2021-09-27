using System.Collections.Generic;

namespace Sudoku
{
    public interface ICell
    {
        int X { get; }
        int Y { get; }
        int CellValue { get; set; }
        HashSet<Location> Neighbors { get; }
        bool ReadOnly { get; }

        void InitAsPredefined(int value);
        void FocusTextbox();
    }
}