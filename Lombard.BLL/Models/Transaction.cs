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
        public decimal TotalPrice => CalculateTotalPrice();
        public decimal TotalProfit => CalculateTotalProfit();

        public Transaction(int transactionID, TransactionType transactionType, Employee employee,
            Customer customer, DateTime transactionDate, IEnumerable<Item> items)
        {
            TransactionID = transactionID;
            TransactionType = transactionType;
            Employee = employee;
            Customer = customer;
            TransactionDate = transactionDate;
            _items = items;
        }

        public decimal CalculateTotalProfit()
        {
            return 1000;
        }

        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach(var item in _items)
            {
                totalPrice += item.SellPrice;
            }

            return totalPrice;
        }
    }
}
