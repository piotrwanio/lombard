using Lombard.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Lombard.DAL.Repositories.Interfaces
{
    public interface ITransactionRepository
    {
        Transaction GetTransaction(int id);
        bool DeleteTransaction(int id);
        bool AddTransaction(Transaction transaction);
        bool UpdateTransaction(Transaction transaction);

        List<Transaction> GetAllTransactions();
        List<Transaction> GetTransactionsByType(TransactionType type);
        List<Transaction> GetTransactionsByClient(Customer customer);
        List<Transaction> GetTransactionByEmployee(Employee employee);



    }
}
