using _07.Composite.Collection;

namespace _07.Composite
{
    public abstract class Control
    {
        private ControlCollection controls;
        public virtual ControlCollection Controls
        {
            get
            {
                if (controls == null)
                {
                    controls = CreateControlCollection();
                }
                return controls;
            }

        }

        public abstract ControlCollection CreateControlCollection();
    }
}
