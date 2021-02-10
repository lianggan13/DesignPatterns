using System;

namespace _06.Factory_Method
{
    public class Car
    {
        public Engine Engine { get; }
        public Car(Engine engine)
        {
            this.Engine = engine;
        }

        public void Drive()
        {
            Engine.Launch();
            Console.WriteLine("The car start to drive");
        }
    }
}
