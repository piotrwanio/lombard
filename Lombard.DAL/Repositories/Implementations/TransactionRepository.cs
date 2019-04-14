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
                _context.TransactionsItems.Add(
                    new TransactionItem
                    {
                        Item = item,
                        Transaction = transaction
                    }
                    );
            }
            _context.SaveChanges();

            return true;
        }

        public bool DeleteTransaction(int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public bool UpdateTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
