using Lombard.BLL.Providers;
using Lombard.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lombard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly ReportProvider _reportProvider;

        public ReportController(ReportProvider reportProvider)
        {
            _reportProvider = reportProvider;
        }

        [HttpGet("")]
        public ActionResult<decimal> GetTotalRotation()
        {
            return _reportProvider.GetTotalProfit();
        }

        [HttpGet("")]
        public ActionResult<decimal> GetTotalProfit()
        {
            return _reportProvider.GetTotalProfit();
        }

        [HttpGet("")]
        public ActionResult<IList<Item>> GetStockStatus()
        {
            return new List<Item>();
        }

        [HttpGet("")]
        public ActionResult<IList<Item>> GetMissingItems()
        {
            return new List<Item>();
        }
    }
}