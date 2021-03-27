using _14.Proxy.Generator;
using _14.Proxy.Model;
using System;

namespace _14.Proxy
{
    class Program
    {
        /// <summary>
        /// 代理模式：控制对象的状态和行为，如：根据情况或条件，返回代理对象或真实对象；
        /// 另：使用事件实现的观察者模式，保证了界面与真实状态的一致性。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ProxyControlGenerator proxy = new ProxyControlGenerator();
            proxy.ControlGeneratedEvent += Proxy_ControlGeneratedEvent;
            proxy.GeneratorControls();
            PrintControl(proxy.Controls);

            Console.WriteLine();
            Console.ReadKey();
        }

        private static void Proxy_ControlGeneratedEvent(object sender, EventArgs e)
        {
            PrintControl((sender as ProxyControlGenerator).Controls);
        }

        private static void PrintControl(Control[] controls)
        {
            foreach (var c in controls)
            {
                Console.WriteLine(c.Name);
            }
        }
    }
}
