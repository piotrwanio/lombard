using System.Collections.Generic;
using Lombard.DAL.Models;

namespace Lombard.BLL.Providers
{
    public interface ITransactionProvider
    {
        void AddTransaction(Transaction transaction);
        List<Transaction> GetTransactions();
        List<Transaction> GetTransactionsByType(TransactionType type);
    }
}