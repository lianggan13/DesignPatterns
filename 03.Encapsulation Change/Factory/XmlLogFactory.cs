using _03.Encapsulation_Change.Logs;

namespace _03.Encapsulation_Change.Factory
{
    public class XmlLogFactory : LogFactory
    {
        public override Log CreateLog() => new XmlLog();
    }
}
