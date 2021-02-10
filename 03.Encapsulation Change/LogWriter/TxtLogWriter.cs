using _03.Encapsulation_Change.Interface;
using System;

namespace _03.Encapsulation_Change.LogWriter
{
    public class TxtLogWriter : ILogWriter
    {
        public void Write(Log log)
        {
            Console.WriteLine("Txt Log: " + log.Content);
        }
    }
}
