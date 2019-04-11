using System;
using System.Collections.Generic;
using System.Text;

namespace Lombard.BLL
{
    public class Item
    {
        public Item(int itemID, string name, decimal purchasePrice, double quantity, string unit)
        {
            ItemID = itemID;
            Name = name;
            PurchasePrice = purchasePrice;
            Quantity = quantity;
            Unit = unit;
        }       

        public int ItemID { get; private set; }
        public string Name { get; private set; }
        public decimal PurchasePrice { get; private set; }
        public double Quantity { get; private set; }
        public string Unit { get; private set; }

        public decimal SellPrice => SetSellingPrice();

        public void UpdateQuantity(int quantity)
        {
            //add validation
            Quantity = quantity;
        }

        public decimal SetSellingPrice()
        {
            throw new NotImplementedException();
        }

        public decimal CalculateProfit()
        {
            throw new NotImplementedException();
        }
    }
}
