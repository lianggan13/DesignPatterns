using _09.Iterator.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Iterator
{
    public class NormalList<T> : List<T>, IIteratorable<T>
    {
        public IIterator<T> GetIterator()
        {
            return new  NormalIterator<T>(this);
        }
    }
}
