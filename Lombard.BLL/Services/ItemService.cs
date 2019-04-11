using System;
using System.Collections.Generic;
using System.Text;

namespace Lombard.BLL.Services
{
    public class ItemService
    {
        private readonly Item _item;

        public ItemService(Item item)
        {
            _item = item;
        }

        public void UpdateQuantity(int quantity)
        {
            //add validation
            _item.Quantity = quantity;
        }

        public void SetSellingPrice(decimal sellingPrice)
        {
            _item.SellingPrice = sellingPrice;
        }

        public decimal CalculateProfit()
        {
            return _item.SellingPrice - _item.PurchasePrice;
        }
    }
}
