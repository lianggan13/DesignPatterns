namespace _16.MultiPattern.Interfaces
{
    public interface IReportFactory
    {
        IReportData CreateReportData();
        IReportFormatter CreateReportFormatter();
        IReportProcessor CreateReportcessor();
    }
}
