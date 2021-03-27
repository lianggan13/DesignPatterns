using _16.MultiPattern.Interfaces;
using System;

namespace _16.MultiPattern.Report
{
    public class CrystaIReportFormatter : IReportFormatter
    {
        public object Parse(string formatFileName)
        {
            string s = $"{nameof(CrystaIReportFormatter)}.{nameof(Parse)}({formatFileName})";
            Console.WriteLine(s);
            return s;
        }
    }
}
