using _06.Factory_Method.Factory;
using System;

namespace _06.Factory_Method
{
    class Program
    {
        /// <summary>
        /// 工厂方法：在为产品建立相应工厂的同时，还需注意划分各个模块的职责。
        /// 最佳方案：将创建工厂对象的职责集中起来，放到一个模块中，而不是在创建产品时，才创建工厂对象。
        /// 错误例子：创建产品时将工厂对象的创建于产品对象的创建放在一起，然后分布在各个模块中。
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            {
                Car benchCar = new Car(new GasolineEngine());
                benchCar.Drive();

                Car teslaCar = new Car(new SolarEngine());
                teslaCar.Drive();
            }

            {
                EngineFactory engineFactory = new SolarEngineFactory();
                Car teslaCar = new Car(engineFactory.MakeEngine());
                teslaCar.Drive();
            }


            {
                EngineCreator engineCreator = new EngineCreator();
                Car teslaCar = new Car(engineCreator.Create("SolarEngineFactory"));
                teslaCar.Drive();
            }

            Console.ReadKey();
        }
    }
}
