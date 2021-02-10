using System;

namespace _03.Encapsulation_Change.Logs
{
    public class TxtLog : Log
    {
        public override void Write(string content)
        {
            Console.WriteLine("Txt Log: " + content);
        }
    }
}
