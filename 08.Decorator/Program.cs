using System;

namespace _08.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Employee e = new Employee("Lianggan13", "1918");

                e.SignIn();
                e.Work();
            }
            {
                User u = new LogDecorator(new Employee("Lianggan13", "1918"));

                u.SignIn();

            }

            {
                User u = new SafeDecorator(new LogDecorator(new Employee("Lianggan13", "1918")));

                u.SignIn();
            }



            Console.ReadKey();
        }
    }
}
