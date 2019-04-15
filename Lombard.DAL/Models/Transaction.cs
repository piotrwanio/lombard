using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lombard.DAL.Models
{
    [Table("Transactions")]
    public class Transaction
    {
        [Key]
        public int? TransactionId { get; set; }
        public virtual IEnumerable<Item> Items { get; set; }
        public TransactionType TransactionType { get; set; }
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
