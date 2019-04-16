using Lombard.DAL.Models;
using Lombard.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lombard.API
{
    public class FakeTransactionRepository : ITransactionRepository
    {
        public bool AddTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Transaction GetTransaction(int id)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> GetTransactions()
        {
            return new List<Transaction>
            {
                new Transaction {
                       TransactionId = 1,
                       TransactionDate = new DateTime(2019,11,12),
                       Items = new List<Item>()
                       {
                new Item {
                        Name = "ooo",
                        PurchasePrice = 888,
                        Quantity = 8
                        },
                new Item {
                        Name = "asd",
                        PurchasePrice = 666,
                        Quantity = 6
                        },
            }
        },
                new Transaction {
                        TransactionId = 2,
                       TransactionDate = new DateTime(2018,11,12),
                       Items = new List<Item>()
                       {
                new Item {
                        Name = "qwe",
                        PurchasePrice = 555,
                        Quantity = 5
                        },
                new Item
                {
                        Name = "zxc",
                        PurchasePrice = 999,
                        Quantity = 9
                },
            }
                        },
                new Transaction {
                        TransactionId = 3,
                       TransactionDate = new DateTime(2017,11,12),
                       Items = new List<Item>()
                       {
                new Item
                {
                        Name = "fgh",
                        PurchasePrice = 111,
                        Quantity = 1
                },
                new Item {
                        Name = "rty",
                        PurchasePrice = 777,
                        Quantity = 7
                }
            }
                        },
            };
        }

        public List<Transaction> GetTransactionsByType(TransactionType type)
        {
            throw new NotImplementedException();
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
