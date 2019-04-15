using Lombard.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lombard.BLL.Services
{
    public class ReportService
    {
        private readonly Report _report;

        public ReportService(Report report)
        {
            _report = report;
        }

        public void GetTotalRotation()
        {
            throw new NotImplementedException();
        }

        public void GetTotalProfit()
        {
            throw new NotImplementedException();
        }

        public void GetStockStatus()
        {
            throw new NotImplementedException();
        }

        public void GetMissingItems()
        {
            throw new NotImplementedException();
        }
    }
}
