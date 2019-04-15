using System;
using System.Collections.Generic;
using System.Text;

namespace Lombard.BLL.Models
{
    public class Report
    {
        public Report(int reportId, double totalRotation, double totalProfit, int stock)
        {
            ReportId = reportId;
            TotalRotation = totalRotation;
            TotalProfit = totalProfit;
            Stock = stock;
        }

        public int ReportId { get; }
        public double TotalRotation { get; }
        public double TotalProfit { get; }
        public int Stock { get; set; }
    }
}
