﻿using Lombard.DAL.Models;
using Lombard.DAL.Repositories.Interfaces;
using System.Collections.Generic;

namespace Lombard.BLL.Providers
{
    public class TransactionProvider : ITransactionProvider
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionProvider(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public void AddTransaction(Transaction transaction)
        {
            _transactionRepository.AddTransaction(transaction);
        }

        public List<Transaction> GetTransactionsByType(TransactionType type)
        {
            return _transactionRepository.GetTransactionsByType(type);
        }

        public List<Transaction> GetTransactions()
        {
            return _transactionRepository.GetTransactions();
        }
    }
}
