using System.Collections.Generic;

namespace SudokuLib.OptionOrder
{
    public class NoOptionOrderer<T> : IOptionsOrderer<T>
    {
        public IEnumerable<T> Order(IEnumerable<T> enumerable) => enumerable;
    }
}