using System;

namespace _07.Composite.Collection
{
    public class EmptyControlCollection : ControlCollection
    {
        public EmptyControlCollection(Control owner) : base(owner)
        {

        }

        public override void Add(Control child)
        {
            throw new Exception("Not support [Add] operation");
        }
        public override bool Remove(Control child)
        {
            throw new Exception("Not support [Remove] operation");
        }
    }
}
