using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Iterator.Iterators
{
    public class NormalIterator<T> : IIterator<T>
    {
        private List<T> source = null;
        private int index = -1;

        public NormalIterator(List<T> s)
        {
            this.source = s;
        }

        public T Current => source.ElementAt(index);

        public T First()
        {
            return this.source.FirstOrDefault();
        }

        public T Last()
        {
            return this.source.LastOrDefault();
        }

        public bool MoveNext()
        {
            index++;
            Console.WriteLine(nameof(MoveNext));
            return source.Count > index;
        }

        public void Reset()
        {
            this.index = 0;
        }
    }
}
