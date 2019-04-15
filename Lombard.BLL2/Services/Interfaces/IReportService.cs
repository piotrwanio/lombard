using Lombard.BLL.ViewModels;

namespace Lombard.BLL.Services
{
    public interface IReportService
    {
        Report GenerateReport();
        Report GenerateReport(string dateTime);
        Report GenerateReport(string fromTime, string toTime);
    }
}