using Lombard.DAL.Models;
using System.Collections.Generic;

namespace Lombard.BLL.ViewModels
{
    public class ReportViewModel
    {
        public decimal SalesTurnover { get; set; }
        public decimal Profit { get; set; }
        public IEnumerable<Transaction> PurchaseTransactions { get; set; }
        public IEnumerable<Transaction> SellingTransactions { get; set; }
        public IEnumerable<StockViewModel> StockState { get; set; }
        public IEnumerable<StockViewModel> MissingItems { get; set; }
    }
}
