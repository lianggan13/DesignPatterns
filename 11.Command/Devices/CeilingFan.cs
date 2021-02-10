using System;

namespace _11.Command.Devices
{
    public class CeilingFan : IDevice
    {
        public void Off()
        {
            Console.WriteLine(nameof(CeilingFan) + " " + nameof(Off));
        }

        public void On()
        {
            Console.WriteLine(nameof(CeilingFan) + " " + nameof(On));
        }

        public void SetLow()
        {
            Console.WriteLine(nameof(CeilingFan) + " " + nameof(SetLow));
        }

        public void SetMedium()
        {
            Console.WriteLine(nameof(CeilingFan) + " " + nameof(SetMedium));
        }

        public void SetHigh()
        {
            Console.WriteLine(nameof(CeilingFan) + " " + nameof(SetHigh));
        }

    }
}
