using System;

namespace _07.Composite
{
    class Program
    {
        /// <summary>
        /// 组合模式：单元素作为统一的接口，是整个结构的抽象，因此单元素和复元素具备同样的抽象接口。
        /// 透明方式：优点，单复元素结构和行为一样，完全消除在抽象层次的差别；缺点，不够安全，单元素不具备增删操作。
        /// 安全方式：优点，单元素不具有管理元素的能力，调用时不会出现透明方式的安全错误；缺点，单复元素接口不完全一致。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                EntityControl child1 = new EntityControl();
                EntityControl child2 = new EntityControl();
                EntityControl child3 = new EntityControl();

                ContainerControl container = new ContainerControl();
                container.Controls.Add(child1);
                container.Controls.Add(child2);
                container.Controls.Add(child3);

                child1.Controls.Add(child3);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                Console.ReadKey();
            }


        }
    }
}
