using _03.Encapsulation_Change.Logs;

namespace _03.Encapsulation_Change.Factory
{
    public class TxtLogFactory : LogFactory
    {
        public override Log CreateLog() => new TxtLog();
    }
}
