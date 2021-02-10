using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Iterator.Iterators
{
    public class Reverselterator<T> : IIterator<T>
    {
        private List<T> source = null;
        private int index = -1;

        public Reverselterator(List<T> s)
        {
            this.source = s;
            this.index = s.Count;
        }

        public T Current => source.ElementAt(index);

        public T First()
        {
            return this.source.LastOrDefault();
        }

        public T Last()
        {
            return this.source.FirstOrDefault();
        }

        public bool MoveNext()
        {
            index--;
            Console.WriteLine(nameof(MoveNext));
            return index >= 0;
        }

        public void Reset()
        {
            this.index = source.Count - 1;
        }
    }
}
