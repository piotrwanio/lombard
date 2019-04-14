using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lombard.DAL.Models
{
    [Table("Items")]
    public class Item
    { 
        public int? ItemId { get; set; }
        public string Name { get; set; }
        public decimal PurchasePrice { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public decimal SellingPrice { get; set; }
    }
}
