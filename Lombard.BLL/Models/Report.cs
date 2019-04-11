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

        private int ReportId { get; }
        private double TotalRotation { get; }
        private double TotalProfit { get; }
        private int Stock { get; }
        
    }
}
