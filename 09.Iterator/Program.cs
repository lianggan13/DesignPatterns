using System;

namespace _09.Iterator
{
    class Program
    {
        /// <summary>
        /// 迭代器：通过将存储数据与访问数据的职责分离，
        /// 在不暴露集合内部结构情况下，提供依次访问集合元素的方法。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            {
                NormalList<int> s = new NormalList<int>();
                s.Add(1);
                s.Add(2);
                s.Add(3);


                var e = s.GetIterator();
                while (e.MoveNext())
                {
                    Console.WriteLine(e.Current);
                }
            }

            {
                ReverseList<int> s = new ReverseList<int>();
                s.Add(1);
                s.Add(2);
                s.Add(3);


                var e = s.GetIterator();
                while (e.MoveNext())
                {
                    Console.WriteLine(e.Current);
                }
            }



            Console.ReadKey();
        }
    }
}
