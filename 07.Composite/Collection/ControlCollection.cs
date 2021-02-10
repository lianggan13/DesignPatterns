using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _07.Composite.Collection
{
    public class ControlCollection : ICollection, IEnumerable
    {
        private Control owner;
        private List<Control> controls;

        public ControlCollection(Control control)
        {
            this.owner = control;
            controls = new List<Control>();
        }

        public int Count => controls?.Count() ?? 0;

        public object SyncRoot => null;

        public bool IsSynchronized => false;


        public void CopyTo(Array array, int index)
        {
            controls.ToArray().CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            return controls.GetEnumerator();
        }

        public virtual void Add(Control child)
        {
            controls.Add(child);
            Console.WriteLine("Add " + nameof(child));
        }

        public virtual bool Remove(Control child)
        {
            return controls.Remove(child);
        }
    }
}
