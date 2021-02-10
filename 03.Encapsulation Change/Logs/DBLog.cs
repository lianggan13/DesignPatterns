using System;

namespace _03.Encapsulation_Change.Logs
{
    public class DBLog : Log
    {
        public override void Write(string content)
        {
            Console.WriteLine("DB Log: " + content);
        }
    }
}
