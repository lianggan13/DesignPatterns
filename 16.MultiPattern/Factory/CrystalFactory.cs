using _16.MultiPattern.Interfaces;
using _16.MultiPattern.Report;

namespace _16.MultiPattern.Factory
{
    public class CrystalFactory : ReportFactory
    {
        public override IReportProcessor CreateReportcessor()
        {
            return new CrystaIReportProcessor();
        }

        public override IReportData CreateReportData()
        {
            return new CrystalReportData();
        }

        public override IReportFormatter CreateReportFormatter()
        {
            return new CrystaIReportFormatter();
        }
    }
}
