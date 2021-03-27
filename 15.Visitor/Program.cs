using _15.Visitor.Adapters;
using _15.Visitor.Interfaces;
using _15.Visitor.RadioMedias;
using _15.Visitor.VideoMedias;
using _15.Visitor.Visitors;
using System;

namespace _15.Visitor
{

    class Program
    {
        /// <summary>
        /// 访问者模式：扩展接口行为，
        /// 抽象：抽象所有的扩展功能为接口，实现扩展功能，定义实现接口类；
        /// 分离：通过对扩展功能的抽象，将这些功能具体实现从原有对象中分离出去，进而通过组合而非继承，获取具体功能对象；
        /// 双重委派：为实现组合关系，需要在原对象中新增方法，接收功能对象，而功能对象的访问方法需接受原对象。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            FMRadio fmRadio = new FMRadio();
            fmRadio.TurnOff();
            fmRadio.Receive();

            IMedia media = new RadioMediaAdapter(fmRadio);
            media.Open();
            media.Play();

            Avi avi = new Avi();
            avi.Accept(new ResizeVisitor());

            Mpeg mpeg = new Mpeg();
            mpeg.Accept(new ResizeVisitor());

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
