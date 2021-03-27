using System;

namespace _15.Visitor.RadioMedias
{
    public class RMRadio : Radio
    {
        public override void ModulateDirection(bool forward)
        {
            string s = string.Format("{0}.{1}({2})", nameof(RMRadio), nameof(ModulateDirection), forward);
            Console.WriteLine(s);
        }

        public override void Receive()
        {
            string s = string.Format("{0}.{1}({2})", nameof(RMRadio), nameof(Receive), string.Empty);
            Console.WriteLine(s);
        }

        public override void Stop()
        {
            string s = string.Format("{0}.{1}({2})", nameof(RMRadio), nameof(Stop), string.Empty);
            Console.WriteLine(s);
        }

        public override void TurnOff()
        {
            string s = string.Format("{0}.{1}({2})", nameof(RMRadio), nameof(TurnOff), string.Empty);
            Console.WriteLine(s);
        }

        public override void TurnOn()
        {
            string s = string.Format("{0}.{1}({2})", nameof(RMRadio), nameof(TurnOn), string.Empty);
            Console.WriteLine(s);
        }
    }
}
