using _16.MultiPattern.Interfaces;
using _16.MultiPattern.Report;

namespace _16.MultiPattern.Factory
{
    public class CellFactory : ReportFactory
    {
        public override IReportProcessor CreateReportcessor()
        {
            return new CellReportProcessor();
        }

        public override IReportData CreateReportData()
        {
            return new CellReportData();
        }

        public override IReportFormatter CreateReportFormatter()
        {
            return new CellReportFormatter();
        }
    }
}
