using _16.MultiPattern.Interfaces;
using System;

namespace _16.MultiPattern.Export
{
    class ExportExcelFile : IExportFile
    {
        public bool Export(string fileName)
        {
            string s = $"{nameof(ExportExcelFile)}.{nameof(Export)}({fileName})";
            Console.WriteLine(s);
            return true;
        }
    }
}
