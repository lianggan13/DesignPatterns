using _16.MultiPattern.Interfaces;
using System;

namespace _16.MultiPattern.Report
{
    public class CellReportData : IReportData
    {
        public object DataSource { get; set; }

        public void InitReportData()
        {
            string s = $"{nameof(CellReportData)}.{nameof(InitReportData)}({string.Empty})";
            Console.WriteLine(s);
        }
    }
}
