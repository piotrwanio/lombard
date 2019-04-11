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

        public int ItemID { get; set; }
        public string Name { get; set; }
        public decimal PurchasePrice { get;  set; }
        public double Quantity { get;  set; }
        public string Unit { get;  set; }
        public decimal SellingPrice { get; set; }

        public void UpdateQuantity(int quantity)
        {
            //add validation
            Quantity = quantity;
        }

        public void SetSellingPrice(decimal sellingPrice)
        {
            SellingPrice = sellingPrice;
        }

        public decimal CalculateProfit()
        {
            return SellingPrice - PurchasePrice;
        }
    }
}
