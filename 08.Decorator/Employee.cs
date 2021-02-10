using _08.Decorator.Interfaces;
using System;

namespace _08.Decorator
{
    /// <summary>
    /// 装饰器：为对象动态添加新的职责，且不修改原有行为。
    /// 
    /// </summary>
    public class Employee : User, IWork
    {

        public Employee(string name, string password) : base(name, password)
        {

        }
        public override void SignIn()
        {
            Console.WriteLine(this.Name + " " + nameof(SignIn));
        }

        public void Work()
        {
            Console.WriteLine(this.Name + " " + nameof(Work));
        }
    }
}
