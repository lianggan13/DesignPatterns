using _07.Composite.Collection;

namespace _07.Composite
{
    public class EntityControl : Control
    {
        public override ControlCollection CreateControlCollection()
        {
            return new EmptyControlCollection(this);
            //return base.CreateControlCollection();
        }
    }
}
