using _14.Proxy.Model;
using System;
using System.Threading.Tasks;

namespace _14.Proxy.Generator
{
    public class ProxyControlGenerator : ControlGenerator
    {
        private RealControlGenerator Real;
        public ProxyControlGenerator()
        {
            Real = new RealControlGenerator();
            Real.ControlGeneratedEvent -= Real_ControlGeneratedEvent;
            Real.ControlGeneratedEvent += Real_ControlGeneratedEvent;
        }

        private void Real_ControlGeneratedEvent(object sender, EventArgs e)
        {
            this.GeneratorControls();
        }

        public override void GeneratorControls()
        {
            if (Real.BeCompleted)
            {
                Controls = new Control[Real.Controls.Length];
                Real.Controls.CopyTo(Controls, 0);
                OnGenerateCompleted();
            }
            else
            {
                Task.Run(() => Real.GeneratorControls());
                if (!Real.BeCompleted)
                {
                    base.GeneratorControls();
                }
            }
        }
    }
}
