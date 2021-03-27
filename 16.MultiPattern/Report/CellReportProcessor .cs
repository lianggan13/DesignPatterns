using _16.MultiPattern.Interfaces;
using System;

namespace _16.MultiPattern.Report
{
    public class CellReportProcessor : IReportProcessor
    {
        public int PageSize { get; set; }
        public int PageOrient { get; set; }

        public bool ExportFile(string fileName, IExportFile export)
        {
            return export.Export(fileName);
        }

        public int Find(IReportData rptData, string searchKey, bool stringCase)
        {
            string s = $"{nameof(CellReportProcessor)}.{nameof(Find)}({rptData})";
            Console.WriteLine(s);
            return 0;
        }

        public int Find(IReportData rptData, string searchKey)
        {
            return Find(rptData, searchKey, false);
        }
    }
}
