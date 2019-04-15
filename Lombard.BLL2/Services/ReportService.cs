﻿using Lombard.DAL.Models;
using System.Collections.Generic;

namespace Lombard.BLL.Services
{
    public class ReportService : IReportService
    {
        public decimal GetTotalRotation()
        {
            return 1_000_000M;
        }

        public decimal GetTotalProfit()
        {
            return 500_000M;
        }

        public IList<Item> GetStockStatus()
        {
            return new List<Item>();
        }

        public IList<Item> GetMissingItems()
        {
            return new List<Item>();
        }
    }
}
