namespace _16.MultiPattern.Interfaces
{
    public interface IReportProcessor
    {
        int PageSize { get; set; }
        int PageOrient { get; set; }
        int Find(IReportData rptData, string searchKey, bool stringCase);
        int Find(IReportData rptData, string searchKey);
        bool ExportFile(string fileName, IExportFile export);
    }
}