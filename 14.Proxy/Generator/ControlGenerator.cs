using _14.Proxy.Model;
using System;
using System.Collections.Generic;

namespace _14.Proxy.Generator
{
    public abstract class ControlGenerator
    {
        public event EventHandler ControlGeneratedEvent;
        public Control[] Controls { get; protected set; }
        public virtual void GeneratorControls()
        {
            List<string> names = new List<string>() { "Proxy TextBox", "Proxy Button", "Proxy Grid" };

            List<Control> ctrls = new List<Control>();
            foreach (var n in names)
            {
                ctrls.Add(new Control() { Name = n });
            }
            Controls = new Control[ctrls.Count];
            ctrls.CopyTo(Controls);
        }

        public virtual void OnGenerateCompleted()
        {
            ControlGeneratedEvent?.Invoke(this, null);
        }
    }
}
