using _15.Visitor.Interfaces;
using System;

namespace _15.Visitor.RadioMedias
{
    public abstract class Radio : IRadio
    {
        public virtual void ModulateDirection(bool forward)
        {
            string s = string.Format("{0}.{1}({2})", nameof(Radio), nameof(ModulateDirection), forward);
            Console.WriteLine(s);
        }

        public virtual void Receive()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Radio), nameof(Receive), string.Empty);
            Console.WriteLine(s);
        }

        public virtual void Stop()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Radio), nameof(Stop), string.Empty);
            Console.WriteLine(s);
        }

        public virtual void TurnOff()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Radio), nameof(TurnOff), string.Empty);
            Console.WriteLine(s);
        }

        public virtual void TurnOn()
        {
            string s = string.Format("{0}.{1}({2})", nameof(Radio), nameof(TurnOn), string.Empty);
            Console.WriteLine(s);
        }
    }
}
