using _03.Encapsulation_Change.Factory;
using _03.Encapsulation_Change.Interface;
using _03.Encapsulation_Change.LogWriter;
using System;

namespace _03.Encapsulation_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            // 封装对象行为变化
            {
                Log log = new Log("Log Content");

                ILogWriter txtLogWriter = new TxtLogWriter();
                ILogWriter xmlLogWriter = new XmlLogWritter();
                ILogWriter dbLogWriter = new DBLogWritter();

                log.Write(txtLogWriter);
                log.Write(xmlLogWriter);
                log.Write(dbLogWriter);
            }
            // 封装对象创建变化
            {
                LogFactory txtlogFactory = new TxtLogFactory();
                LogFactory xmlLogFactory = new XmlLogFactory();
                LogFactory dbLogFactory = new DBLogFactory();

                Log txtLog = txtlogFactory.CreateLog();
                Log xmlLog = xmlLogFactory.CreateLog();
                Log dbLog = dbLogFactory.CreateLog();

                txtLog.Write("Txt Log...");
                xmlLog.Write("Xml Log...");
                dbLog.Write("DB Log...");
            }
            // 封装对象结构变化
            {

            }


            Console.ReadLine();
        }
    }
}
