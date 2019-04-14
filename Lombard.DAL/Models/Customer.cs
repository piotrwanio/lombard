using System.ComponentModel.DataAnnotations.Schema;

namespace Lombard.DAL.Models
{
    [Table("Customers")]
    public class Customer : Person
    {
        public int CustomerID { get; set; }
    }
}