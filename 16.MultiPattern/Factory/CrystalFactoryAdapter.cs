using _16.MultiPattern.Interfaces;
using _16.MultiPattern.Schema;

namespace _16.MultiPattern.Factory
{
    public class CrystalFactoryAdapter : CrystalFactory
    {
        public override IReportSchema CreateReportShema()
        {
            return new CrystalSchema();
        }
    }
}
