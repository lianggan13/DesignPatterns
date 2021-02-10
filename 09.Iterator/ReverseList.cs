using _09.Iterator.Iterators;
using System.Collections.Generic;

namespace _09.Iterator
{
    public class ReverseList<T> : List<T>, IIteratorable<T>
    {
        public IIterator<T> GetIterator()
        {
            return new Reverselterator<T>(this);
        }
    }
}
