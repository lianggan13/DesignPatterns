using _16.MultiPattern.Export;
using _16.MultiPattern.Factory;
using _16.MultiPattern.Interfaces;
using System;

namespace _16.MultiPattern
{
    /// <summary>
    /// 设计模式综合运用：抽象工厂模式(IReportFactory)、策略模式(IExportFile)、桥接模式(IExportFile & IReportProcessor)、适配器模式(IReportFactory & CrystalFactory & CrystalFactoryAdapter)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            {
                IReportFactory crystalFactory = new CrystalFactory();
                IReportData data = crystalFactory.CreateReportData();
                IReportFormatter formatter = crystalFactory.CreateReportFormatter();
                IReportProcessor processor = crystalFactory.CreateReportcessor();

                data.InitReportData();
                formatter.Parse("pattern");
                processor.ExportFile("filenName", new ExportExcelFile());
                processor.ExportFile("filenName", new ExportPDFFile());
                processor.ExportFile("filenName", new ExportWordFile());

            }
            {
                ReportFactory reportFactory = new CrystalFactoryAdapter();
                reportFactory.CreateReportShema();
            }

            Console.ReadKey();
        }
    }
}
