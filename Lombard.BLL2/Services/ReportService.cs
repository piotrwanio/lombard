using Lombard.BLL.ViewModels;
using Lombard.DAL.Models;
using Lombard.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lombard.BLL.Services
{
    public class ReportService : IReportService
    {
        private readonly ITransactionRepository _transactionRepository;

        public ReportService(ITransactionRepository transactionRepository)
        {           
            _transactionRepository = transactionRepository;
        }

        public Report GenerateReport()
        {
            var transactions = _transactionRepository.GetTransactions();
            return new Report
            {
                MissingItems = GetMissingItems(transactions),
                Profit = GetTotalProfit(transactions),
                SalesTurnover = GetTotalSalesTurnover(transactions),
                StockState = GetStockStatus(transactions)
            };
        }

        public Report GenerateReport(string dateTime)
        {
            var transactions = _transactionRepository.GetTransactions()
                .Where(t => t.TransactionDate == DateTime.Parse(dateTime))
                .ToList();

            return new Report
            {
                MissingItems = GetMissingItems(transactions),
                Profit = GetTotalProfit(transactions),
                SalesTurnover = GetTotalSalesTurnover(transactions),
                StockState = GetStockStatus(transactions)
            };
        }

        public Report GenerateReport(string fromTime, string toTime)
        {
            var transactions = _transactionRepository.GetTransactions()
                .Where(t => t.TransactionDate > DateTime.Parse(fromTime) && t.TransactionDate < DateTime.Parse(toTime))
                .ToList();

            return new Report
            {
                MissingItems = GetMissingItems(transactions),
                Profit = GetTotalProfit(transactions),
                SalesTurnover = GetTotalSalesTurnover(transactions),
                StockState = GetStockStatus(transactions)
            };
        }

        private decimal GetTotalSalesTurnover(IList<Transaction> transactions)
        {
            return transactions.Sum(x => x.Items.Sum(i => i.PurchasePrice));
        }

        private decimal GetTotalProfit(IList<Transaction> transactions)
        {
            //return transactions.Sum(x => x.Items.Sum(i => i.SellingPrice - i.PurchasePrice));
            return 10000000M;
        }

        private IList<Item> GetStockStatus(IList<Transaction> transactions)
        {
            var items = new List<Item>();
            transactions.ToList().ForEach(t => items.AddRange(t.Items));
            return items;
        }

        private IList<Item> GetMissingItems(IList<Transaction> transactions)
        {
            var items = new List<Item>();
            transactions.ToList()
                .ForEach(t => items
                .AddRange(t.Items
                .Where(i => i.Quantity <3)));
            return items;
        }
    }
}
