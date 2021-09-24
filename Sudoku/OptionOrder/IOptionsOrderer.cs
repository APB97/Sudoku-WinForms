using System.Collections.Generic;

namespace SudokuLib.OptionOrder
{
    public interface IOptionsOrderer<T>
    {
        IEnumerable<T> Order(IEnumerable<T> enumerable);
    }
}