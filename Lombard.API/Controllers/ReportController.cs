using Lombard.BLL.Services;
using Lombard.BLL.ViewModels;
using Lombard.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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
        public ActionResult<Report> GetReportFromAll()
        {
            return _reportService.GenerateReport();
        }

        [HttpGet("{dateTime}")]
        public ActionResult<Report> GetReportFromDate(DateTime dateTime)
        {
            return _reportService.GenerateReport(dateTime);
        }

        [HttpGet("{fromTime}/{toTime}")]
        public ActionResult<Report> GetReportFromTimeScope(DateTime fromTime, DateTime toTime)
        {
            return _reportService.GenerateReport(fromTime, toTime);
        }
    }
}