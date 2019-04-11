using System;
using System.Collections.Generic;
using System.Text;

namespace Lombard.BLL
{
    public class Transaction
    {
        private readonly IEnumerable<Item> _items;
        public int TransactionID { get; }
        public TransactionType TransactionType { get; }
        public Employee Employee { get; }
        public Customer Customer { get; }
        public DateTime TransactionDate { get; }
        public double TotalPrice => CalculateTotalPrice();
        public double TotalProfit => CalculateTotalProfit();

        public Transaction(int transactionID, TransactionType transactionType, Employee employee,
            Customer customer, DateTime transactionDate)
        {
            TransactionID = transactionID;
            TransactionType = transactionType;
            Employee = employee;
            Customer = customer;
            TransactionDate = transactionDate;
        }

        private double CalculateTotalProfit()
        {
            throw new NotImplementedException();
        }

        public double CalculateTotalPrice()
        {
            throw new NotImplementedException();
        }
    }
}
