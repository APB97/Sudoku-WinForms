using System;
using System.Collections.Generic;
using System.Linq;

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
            {
                int randomIndex =_random.Next(i);
                (orderedArray[i], orderedArray[randomIndex]) = (orderedArray[randomIndex], orderedArray[i]);
            }
            return orderedArray;
        }
    }
}
