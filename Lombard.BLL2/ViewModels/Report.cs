using Lombard.DAL.Models;
using System.Collections.Generic;

namespace Lombard.BLL.ViewModels
{
    public class Report
    {
        public decimal SalesTurnover { get; set; }
        public decimal Profit { get; set; }
        public IEnumerable<Item> StockState { get; set; }
        public IEnumerable<Item> MissingItems { get; set; }
    }
}
