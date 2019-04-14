using System;
using System.Collections.Generic;
using System.Text;

namespace Lombard.DAL.Models
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

        public int ReportId { get; set; }
        public double TotalRotation { get; set; }
        public double TotalProfit { get; set; }
        public int Stock { get; set; }
    }
}
