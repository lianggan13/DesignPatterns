using _03.Encapsulation_Change.Interface;
using System;

namespace _03.Encapsulation_Change.LogWriter
{
    public class XmlLogWritter : ILogWriter
    {
        public void Write(Log log)
        {
            Console.WriteLine("XML Log: " + log.Content);
        }
    }
}
