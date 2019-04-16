using Lombard.DAL.Models;
using Lombard.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lombard.DAL.Repositories.Implementations
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly EFDbContext _context;

        public TransactionRepository(EFDbContext context)
        {
            _context = context;
        }

        public bool AddTransaction(Transaction transaction)
        {
            if(transaction == null)
            {
                throw new ArgumentNullException();
            }

            var items = ((List<Item>)transaction.Items);

            transaction.Items = null;
            _context.Transactions.Add(transaction);

            foreach (var item in items)
            {
                int id = item.ItemId.GetValueOrDefault();
                transaction.Customer = new Customer();
                transaction.Employee = new Employee();

                if (id == 0 || id < 0)
                {
                    _context.TransactionsItems.Add(
                        new TransactionItem
                        {
                            Item = item,
                            Transaction = transaction
                        });
                }
                else
                {
                    _context.TransactionsItems.Add(
                        new TransactionItem
                        {
                            ItemId = id,
                            Transaction = transaction
                        }
                        );
                }
            }
            _context.SaveChanges();

            return true;
        }

        public bool DeleteTransaction(Transaction transaction)
        {
            _context.Remove(transaction);

            return true;
        }

        public Transaction GetTransaction(int id)
        {
            return _context.Transactions.Where(t => t.TransactionId == id).FirstOrDefault();
        }

        public List<Transaction> GetTransactions()
        {
            List<Transaction> transactions = (from t in _context.Transactions
                                              select t)?.ToList();
            List<TransactionItem> transactionItems = (from t in _context.TransactionsItems.Include("Item")
                                                      select t)?.ToList();

            foreach (var transaction in transactions)
            {
                transaction.Items = new List<Item>();

                var currentTrans = transactionItems
                    .Where(t => t.TransactionId == transaction.TransactionId);

                foreach (var t in currentTrans)
                {
                    ((List<Item>)transaction.Items).Add(t.Item);
                }
            }

            return transactions;
        }

        public List<Transaction> GetTransactionsByType(TransactionType type)
        {
            List<Transaction> transactions = GetTransactions();

            return (from t in transactions
                    where t.TransactionType == type
                    select t)?.ToList();
        }

        public List<Transaction> GetTransactionsInTimeRange(DateTime dateFrom, DateTime dateTo)
        {
            List<Transaction> transactions = GetTransactions();

            return (from t in transactions
                    where (t.TransactionDate >= dateFrom
                    && t.TransactionDate <= dateTo)
                    select t)?.ToList();
        }

        public bool UpdateTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
