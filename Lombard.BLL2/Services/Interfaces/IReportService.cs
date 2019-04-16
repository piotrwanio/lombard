using Lombard.BLL.ViewModels;
using System;

namespace Lombard.BLL.Services
{
    public interface IReportService
    {
        ReportViewModel GenerateReport();
        ReportViewModel GenerateReport(DateTime dateTime);
        ReportViewModel GenerateReport(DateTime fromTime, DateTime toTime);
    }
}