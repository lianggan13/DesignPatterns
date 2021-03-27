using _16.MultiPattern.Interfaces;
using System;

namespace _16.MultiPattern.Schema
{
    public class CellSchema : IReportSchema
    {
        public void Create()
        {
            string s = $"{nameof(CellSchema)}.{nameof(Create)}({string.Empty})";
            Console.WriteLine(s);
        }
    }
}
