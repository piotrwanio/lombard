using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lombard.DAL.Models
{
    [Table("TransactionsItems")]
    public class TransactionItem
    {
        public int? TransactionItemId { get; set; }
        public int TransactionId { get; set; }
        public int ItemId { get; set; }

        [ForeignKey("TransactionId")]
        public Transaction Transaction { get; set; }

        [ForeignKey("ItemId")]
        public Item Item { get; set; }
    }
}
