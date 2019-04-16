using System.Collections.Generic;
using Lombard.DAL.Models;

namespace Lombard.BLL.Services
{
    public interface ITransactionService
    {
        void AddTransaction(Transaction transaction);
        List<Transaction> GetTransactions();
        List<Transaction> GetTransactionsByType(TransactionType type);
    }
}