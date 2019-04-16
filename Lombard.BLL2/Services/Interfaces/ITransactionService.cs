using Lombard.DAL.Models;
using System.Collections.Generic;

namespace Lombard.BLL.Services
{
    public interface ITransactionService
    {
        void AddTransaction(Transaction transaction);
        List<Transaction> GetTransactions();
        List<Transaction> GetTransactionsByType(TransactionType type);
    }
}