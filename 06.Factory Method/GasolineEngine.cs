using System;

namespace _06.Factory_Method
{
    public class GasolineEngine : Engine
    {
        public override void Launch()
        {
            Console.WriteLine("Launch " + nameof(GasolineEngine));
        }
    }
}
