using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public struct Pozycja
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Pozycja(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
