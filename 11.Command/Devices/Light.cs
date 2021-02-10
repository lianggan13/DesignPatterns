using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Command.Devices
{
    public class Light : IDevice
    {
        public void Off()
        {
            Console.WriteLine(nameof(Light) + " " + nameof(Off));
        }

        public void On()
        {
            Console.WriteLine(nameof(Light) + " " + nameof(On));
        }
    }
}
