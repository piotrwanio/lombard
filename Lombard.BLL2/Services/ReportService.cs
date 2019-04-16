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
        private readonly IItemRepository _itemRepository;

        public ReportService(ITransactionRepository transactionRepository, IItemRepository itemRepository)
        {
            _transactionRepository = transactionRepository;
            _itemRepository = itemRepository;
        }

        public ReportViewModel GenerateReport()
        {
            var transactions = _transactionRepository.GetTransactions();
            var items = _itemRepository.GetItems();

            return new ReportViewModel
            {
                MissingItems = GetMissingItems(items),
                Profit = GetTotalProfit(transactions),
                SalesTurnover = GetTotalSalesTurnover(transactions),
                StockState = GetStockStatus(items),
                PurchaseTransactions = GetPurchaseTransactions(transactions),
                SellingTransactions = GetSellingTransactions(transactions)
            };
        }

        public ReportViewModel GenerateReport(DateTime dateTime)
        {
            var transactions = _transactionRepository.GetTransactions()
                .Where(t => t.TransactionDate == dateTime)
                .ToList();
            var items = _itemRepository.GetItems();

            return new ReportViewModel
            {
                MissingItems = GetMissingItems(items),
                Profit = GetTotalProfit(transactions),
                SalesTurnover = GetTotalSalesTurnover(transactions),
                StockState = GetStockStatus(items),
                PurchaseTransactions = GetPurchaseTransactions(transactions),
                SellingTransactions = GetSellingTransactions(transactions)
            };
        }

        public ReportViewModel GenerateReport(DateTime fromTime, DateTime toTime)
        {
            var transactions = _transactionRepository.GetTransactions()
                .Where(t => t.TransactionDate >= fromTime && t.TransactionDate <= toTime)
                .ToList();
            var items = _itemRepository.GetItems();

            return new ReportViewModel
            {
                MissingItems = GetMissingItems(items),
                Profit = GetTotalProfit(transactions),
                SalesTurnover = GetTotalSalesTurnover(transactions),
                StockState = GetStockStatus(items),
                PurchaseTransactions = GetPurchaseTransactions(transactions),
                SellingTransactions = GetSellingTransactions(transactions)
            };
        }

        private decimal GetTotalSalesTurnover(IList<Transaction> transactions)
        {
            return transactions.Sum(t => t.Items.Sum(i => i.PurchasePrice * (decimal)i.Quantity));
        }

        private decimal GetTotalProfit(IList<Transaction> transactions)
        {
            var purchaseTransactions = GetPurchaseTransactions(transactions);
            var sellingTransactions = GetSellingTransactions(transactions);

            var pTSum = purchaseTransactions.ToList().Sum(t => t.Items.Sum(i => i.PurchasePrice * (decimal)i.Quantity));
            var STSum = sellingTransactions.ToList().Sum(t => t.Items.Sum(i => i.PurchasePrice * (decimal)i.Quantity));

            return STSum - pTSum;
        }

        private IList<StockViewModel> GetStockStatus(IList<Item> items) => items.GroupBy(i => i.Name)
                 .Select(x => new StockViewModel
                 {
                     Name = x.Key,
                     Quantity = x.Select(y => y.Quantity).Sum()
                 })
                 .ToList();

        private IList<StockViewModel> GetMissingItems(IList<Item> items)
        {
            return items.GroupBy(i => i.Name)
                 .Select(x => new StockViewModel
                 {
                     Name = x.Key,
                     Quantity = x.Select(y => y.Quantity).Sum()
                 })                 
                 .Where(i => i.Quantity <=3)
                 .ToList();
        }

        private IList<Transaction> GetPurchaseTransactions(IList<Transaction> transactions)
        {
            return transactions.Where(t => t.TransactionType == TransactionType.Purchase).ToList();
        }

        private IList<Transaction> GetSellingTransactions(IList<Transaction> transactions)
        {
            return transactions.Where(t => t.TransactionType == TransactionType.Sell).ToList();
        }
    }
}
