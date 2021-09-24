using System.Collections.Generic;
using System.Linq;

namespace SudokuLib.OptionOrder
{
    public class OptionReverseOrderer<T> : IOptionsOrderer<T>
    {
        public IEnumerable<T> Order(IEnumerable<T> enumerable)
        {
            var reversedArray = enumerable.Reverse().ToArray();
            return reversedArray;
        }
    }
}