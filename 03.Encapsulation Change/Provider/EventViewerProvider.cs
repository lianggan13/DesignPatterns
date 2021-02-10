using System;

namespace _03.Encapsulation_Change.Provider
{
    public class EventViewerProvider : Log
    {
        private Log m_log;
        public EventViewerProvider(Log log)
        {
            this.m_log = log;
        }
        public override void Write(string content)
        {
            LogToEventViewer(content);
            base.Write(content);
        }

        private void LogToEventViewer(string content)
        {
            Console.WriteLine(content);
        }
    }

}
