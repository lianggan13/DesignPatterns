using _16.MultiPattern.Interfaces;
using System;

namespace _16.MultiPattern.Schema
{
    public class CrystalSchema : IReportSchema
    {
        public void Create()
        {
            string s = $"{nameof(CrystalSchema)}.{nameof(Create)}({string.Empty})";
            Console.WriteLine(s);
        }
    }
}
