using Lombard.DAL.Models;
using System;
using System.Collections.Generic;

namespace Lombard.DAL.Repositories.Interfaces
{
    public interface ITransactionRepository
    {
        Transaction GetTransaction(int id);
        bool DeleteTransaction(Transaction transaction);
        bool AddTransaction(Transaction transaction);
        bool UpdateTransaction(Transaction transaction);

        List<Transaction> GetTransactions();
        List<Transaction> GetTransactionsInTimeRange(DateTime dateFrom, DateTime dateTo);
        List<Transaction> GetTransactionsByType(TransactionType type);
    }
}
