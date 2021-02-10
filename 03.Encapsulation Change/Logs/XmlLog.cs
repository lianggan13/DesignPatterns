using System;

namespace _03.Encapsulation_Change.Logs
{
    public class XmlLog : Log
    {
        public override void Write(string content)
        {
            Console.WriteLine("Xml Log: " + content);
        }
    }
}
