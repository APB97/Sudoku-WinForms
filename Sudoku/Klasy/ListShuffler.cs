﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    /// <summary>
    /// Klasa która pozwala na pomieszanie list(y)
    /// </summary>
    static class ListShuffler
    {
        static Random rng;

        static ListShuffler()
        {
            rng = new Random();
        }

        /// <summary>
        /// Pozwala na pseudolosowe zamienienie kolejności elementów listy.
        /// </summary>
        /// <typeparam name="T">Rodzaj zawartości listy.</typeparam>
        /// <param name="list">Lista do pomieszania.</param>
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