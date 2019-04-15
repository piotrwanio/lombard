using System;
using System.Collections.Generic;
using System.Text;

namespace Lombard.BLL.Models
{
    public class Item
    {
        public Item(int itemID, string name, decimal purchasePrice, double quantity, string unit, decimal sellingPrice)
        {
            ItemID = itemID;
            Name = name;
            PurchasePrice = purchasePrice;
            Quantity = quantity;
            Unit = unit;
            SellingPrice = sellingPrice;
        }

        public int ItemID { get; set; }
        public string Name { get; set; }
        public decimal PurchasePrice { get; set; }
        //Do wyjebania
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public decimal SellingPrice { get; set; }
    }
}
