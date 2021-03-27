using _16.MultiPattern.Interfaces;
using System;

namespace _16.MultiPattern.Export
{
    public class ExportWordFile : IExportFile
    {
        public bool Export(string fileName)
        {
            string s = $"{nameof(ExportWordFile)}.{nameof(Export)}({fileName})";
            Console.WriteLine(s);
            return true;
        }
    }
}
