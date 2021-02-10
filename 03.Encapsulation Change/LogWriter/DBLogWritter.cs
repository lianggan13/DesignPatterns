using _03.Encapsulation_Change.Interface;
using System;

namespace _03.Encapsulation_Change.LogWriter
{
    public class DBLogWritter : ILogWriter
    {
        public void Write(Log log)
        {
            Console.WriteLine("DB Log: " + log.Content);
        }
    }
}
