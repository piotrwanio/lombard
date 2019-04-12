using System.ComponentModel.DataAnnotations.Schema;

namespace Lombard.DAL.Models
{
    [Table("Employees")]
    public class Employee : Person
    {
        public int EmployeeID { get; set; }
    }
}