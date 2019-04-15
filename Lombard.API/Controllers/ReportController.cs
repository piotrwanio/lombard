﻿using Lombard.BLL.Services;
using Lombard.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lombard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportProvider;

        public ReportController(IReportService reportProvider)
        {
            _reportProvider = reportProvider;
        }

        [HttpGet("rot/")]
        public ActionResult<decimal> GetTotalRotation()
        {
            return _reportProvider.GetTotalProfit();
        }

        [HttpGet("profit/")]
        public ActionResult<decimal> GetTotalProfit()
        {
            return _reportProvider.GetTotalProfit();
        }

        [HttpGet("stock/")]
        public ActionResult<IList<Item>> GetStockStatus()
        {
            return new List<Item>();
        }

        [HttpGet("missing/")]
        public ActionResult<IList<Item>> GetMissingItems()
        {
            return new List<Item>();
        }
    }
}