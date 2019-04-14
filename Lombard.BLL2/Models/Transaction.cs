using System;
using System.Collections.Generic;
using System.Text;

namespace Lombard.BLL.Models
{
    public class Transaction
    {
        public IEnumerable<Item> Items { get; }
        public int TransactionID { get; }
        public TransactionType TransactionType { get; }
        public Employee Employee { get; }
        public Customer Customer { get; }
        public DateTime TransactionDate { get; }
        
        public Transaction(int transactionID, TransactionType transactionType, Employee employee,
            Customer customer, DateTime transactionDate, IEnumerable<Item> items)
        {
            TransactionID = transactionID;
            TransactionType = transactionType;
            Employee = employee;
            Customer = customer;
            TransactionDate = transactionDate;
            Items = items;
        }
    }
}
