using _03.Encapsulation_Change.Interface;
using System;

namespace _03.Encapsulation_Change
{
    public class Log
    {

        public string Content { get; set; }
        public Log() { }
        public Log(string content)
        {
            this.Content = content;
        }

        public virtual void Write(string content)
        {
            Console.WriteLine(content);
        }

        public void Write(ILogWriter logWriter)
        {
            logWriter.Write(this);
        }

        //public virtual void Write(string content)
        //{
        //    Console.WriteLine(this.Content);
        //}
    }
}
