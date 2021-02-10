using System;

namespace _12.ChainOfResponsibility
{
    /// <summary>
    /// 责任链模式：共同职责对象放入同一链中，根据请求判断职责的具体执行对象
    /// 允许一个请求对象沿着对象链不断向上提交，直到请求对象被某一职责对象处理
    /// 在创建所有职责对象中，每个职责对象保存下一个职责对象的引用
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            Employee employee = new Employee();
            employee.PullTicket(manager.PushTicket());
            employee.CancelTicket();

            Console.ReadKey();
        }
    }
}
