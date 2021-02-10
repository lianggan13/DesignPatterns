using System;

namespace _11.Command.Devices
{
    public class TV : IDevice
    {
        public void Off()
        {
            Console.WriteLine(nameof(TV) + " " + nameof(Off));
        }

        public void On()
        {
            Console.WriteLine(nameof(TV) + " " + nameof(On));
        }
    }
}
