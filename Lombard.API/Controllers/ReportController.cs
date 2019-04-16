using Lombard.BLL.Services;
using Lombard.BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Lombard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet("")]
        public ActionResult<ReportViewModel> GetReportFromAll()
        {
            return _reportService.GenerateReport();
        }

        [HttpGet("{dateTime}")]
        public ActionResult<ReportViewModel> GetReportFromDate(DateTime dateTime)
        {
            return _reportService.GenerateReport(dateTime);
        }

        [HttpGet("{fromTime}/{toTime}")]
        public ActionResult<ReportViewModel> GetReportFromTimeScope(DateTime fromTime, DateTime toTime)
        {
            return _reportService.GenerateReport(fromTime, toTime);
        }
    }
}