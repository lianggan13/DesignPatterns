using _07.Composite.Collection;

namespace _07.Composite
{
    public class ContainerControl : EntityControl
    {
        public override ControlCollection CreateControlCollection()
        {
            //return base.CreateControlCollection();
            return new ControlCollection(this);
        }

    }
}
