using System;

namespace _06.Factory_Method
{
    public class SolarEngine : Engine
    {
        public override void Launch()
        {
            Console.WriteLine("Launch " + nameof(SolarEngine));
        }
    }
}
