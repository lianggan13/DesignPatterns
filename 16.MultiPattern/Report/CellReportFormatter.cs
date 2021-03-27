using _16.MultiPattern.Interfaces;
using System;

namespace _16.MultiPattern.Report
{
    public class CellReportFormatter : IReportFormatter
    {
        public object Parse(string formatFileName)
        {
            string s = $"{nameof(CellReportFormatter)}.{nameof(Parse)}({formatFileName})";
            Console.WriteLine(s);
            return s;
        }
    }
}
