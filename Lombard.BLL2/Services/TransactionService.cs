using Lombard.DAL.Models;

namespace Lombard.BLL.Services
{
    public class TransactionService
    {
        private readonly Transaction _transaction;
        public decimal TransactionTotalPrice => CalculateTotalPrice();
        public decimal TransactionTotalProfit => CalculateTotalProfit();

        public TransactionService(Transaction transaction)
        {
            _transaction = transaction;
        }

        public decimal CalculateTotalProfit()
        {
            return 1000;
        }

        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (var item in _transaction.Items)
            {
                totalPrice += item.SellingPrice;
            }

            return totalPrice;
        }
    }
}
