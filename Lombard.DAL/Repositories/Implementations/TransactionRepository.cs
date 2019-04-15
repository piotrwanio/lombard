using Lombard.DAL.Models;
using Lombard.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Lombard.DAL.Repositories.Implementations
{
    public class TransactionRepository : ITransactionRepository
    {
        EFDbContext _context;

        public TransactionRepository(EFDbContext context)
        {
            _context = context;
        }

        public bool AddTransaction(Transaction transaction)
        {
            _context.Transactions.Add(transaction);

            var items = ((List<Item>)transaction.Items);

            foreach (var item in items)
            {
                Item itemTest = _context.Items.Find(item?.ItemId);
                if (itemTest == null) itemTest = item;

                _context.TransactionsItems.Add(
                    new TransactionItem
                    {
                        Item = itemTest,
                        Transaction = transaction
                    }
                    );
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
            throw new NotImplementedException();
        }

        public List<Transaction> GetTransactionByEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> GetTransactions()
        {
            List<Transaction> transactions = (from t in _context.Transactions
                                              select t)?.ToList();
            List<TransactionItem> transactionItems = (from t in _context.TransactionsItems.Include("Item")
                                                      select t)?.ToList();

            foreach(var transaction in transactions)
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

        public List<Transaction> GetTransactionsByClient(Customer customer)
        {
            List<Transaction> transactions = GetTransactions();

            return (from t in transactions
                    where t.Customer == customer
                    select t)?.ToList();
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
