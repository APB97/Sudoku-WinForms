using Sudoku.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    static class Jezyk
    {
        public static IKomunikaty Komunikaty { get; set; };

        static Jezyk()
        {
            Komunikaty = new KomunikatyPL();
        }
    }
}
