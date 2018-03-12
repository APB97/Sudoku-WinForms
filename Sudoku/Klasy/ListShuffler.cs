using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    static class ListShuffler
    {
        static Random rng;

        static ListShuffler()
        {
            rng = new Random();
        }

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int i = rng.Next(n + 1);
                T val = list[i];
                list[i] = list[n];
                list[n] = val;
            }
        }
    }
}
