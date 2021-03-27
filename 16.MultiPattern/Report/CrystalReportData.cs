using _16.MultiPattern.Interfaces;
using System;

namespace _16.MultiPattern.Report
{
    public class CrystalReportData : IReportData
    {
        public object DataSource { get; set; }

        public void InitReportData()
        {
            string s = $"{nameof(CrystalReportData)}.{nameof(InitReportData)}({string.Empty})";
            Console.WriteLine(s);
        }
    }
}
