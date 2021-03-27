using _14.Proxy.Model;
using System.Collections.Generic;
using System.Threading;


namespace _14.Proxy.Generator
{
    public class RealControlGenerator : ControlGenerator
    {
        public bool BeCompleted { get; private set; }

        public override void GeneratorControls()
        {
            //base.GeneratorControls();

            List<string> names = new List<string>() { "Real TextBox", "Real Button", "Real Grid" };

            List<Control> ctrls = new List<Control>();
            foreach (var n in names)
            {
                ctrls.Add(new Control() { Name = n });
            }
            Controls = new Control[ctrls.Count];
            ctrls.CopyTo(Controls);
            Thread.Sleep(3000);

            BeCompleted = true;
            OnGenerateCompleted();
        }
    }
}
