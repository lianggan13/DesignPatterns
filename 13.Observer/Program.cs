using _13.Observer.Model;
using System;

namespace _13.Observer
{
    class Program
    {
        /// <summary>
        /// 观察者模式:行为控制一对多的依赖关系，当一个对象的状态发生改变时，所有依赖于它的对象都得到通知并被自动更新;
        /// 被观察者(主体、发布者)维护观察者集合对象，在消息通知时，被观察者将遍历观察者对象集合，并调用其方法
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            StateNotifier notifier = new StateNotifier();
            ManufactureLarge obsLarge = new ManufactureLarge();
            ManufactureMiddle obsMiddle = new ManufactureMiddle();
            ManufactureLow obsLow = new ManufactureLow();
            obsLarge.RegisterStateNotifier(notifier);
            obsMiddle.RegisterStateNotifier(notifier);
            obsLow.RegisterStateNotifier(notifier);

            Equipment eqp = new Equipment(notifier);
            eqp.State = EQPState.Online;
            eqp.State = EQPState.Offline;

            Console.ReadKey();
        }
    }
}
