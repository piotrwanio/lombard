using Lombard.BLL.ViewModels;
using System;

namespace Lombard.BLL.Services
{
    public interface IReportService
    {
        Report GenerateReport();
        Report GenerateReport(DateTime dateTime);
        Report GenerateReport(DateTime fromTime, DateTime toTime);
    }
}