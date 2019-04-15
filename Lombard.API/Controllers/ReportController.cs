using Lombard.BLL.Services;
using Lombard.BLL.ViewModels;
using Lombard.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lombard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService reportProvider)
        {
            _reportService = reportProvider;
        }

        [HttpGet("")]
        public ActionResult<Report> GetReportFromAll()
        {
            return _reportService.GenerateReport();
        }

        [HttpGet("{dateTime}")]
        public ActionResult<Report> GetReportFromDate(string dateTime)
        {
            return _reportService.GenerateReport();
        }

        [HttpGet("{fromTime}/{toTime}")]
        public ActionResult<Report> GetReportFromTimeScope()
        {
            return _reportService.GenerateReport();
        }
    }
}