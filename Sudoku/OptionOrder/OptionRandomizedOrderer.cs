using System;
using System.Collections.Generic;
using System.Linq;
using SudokuLib.Helpers;

namespace SudokuLib.OptionOrder
{
    public class OptionRandomizedOrderer<T> : IOptionsOrderer<T>
    {
        private readonly Random _random = new Random();
        
        public IEnumerable<T> Order(IEnumerable<T> enumerable)
        {
            var orderedArray = enumerable.ToArray();
            int count = orderedArray.Count();
            for (int i = count - 1; i > 1; i--)
                SwapHelper.Swap(ref orderedArray[i], ref orderedArray[_random.Next(i)]);
            return orderedArray;
        }
    }
}
