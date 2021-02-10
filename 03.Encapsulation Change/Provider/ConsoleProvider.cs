using System;

namespace _03.Encapsulation_Change.Provider
{
    public class ConsoleProvider : Log
    {

        private Log m_log;
        public ConsoleProvider(Log log)
        {
            this.m_log = log;
        }

        public override void Write(string content)
        {
            Console.WriteLine(content);
            this.Write(content);
        }
    }
}
