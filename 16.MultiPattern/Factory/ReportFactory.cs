using _16.MultiPattern.Interfaces;

namespace _16.MultiPattern.Factory
{
    public abstract class ReportFactory : IReportFactory
    {
        public abstract IReportData CreateReportData();
        public abstract IReportFormatter CreateReportFormatter();
        public abstract IReportProcessor CreateReportcessor();

        public virtual IReportSchema CreateReportShema()
        {
            return null;
        }
    }
}
