using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lombard.BLL.Tests
{
    [TestFixture]
    public class TransactionServiceTests
    {
        [Test]
        public void CalculateTotalProfit_ValidTransaction_Success()
        {
            //var transaction = new Transaction(1, TransactionType.Purchase, 
            //    new Employee { EmpoyeeID = 1, FirstName = "Imię", LastName = "Nazwisko"},
            //    new Customer { }, new DateTime { }, new List<Item> {
            //        new Item(1, "Łódka", 5000, 1, "sztuka" ),
            //        new Item(1, "Łódka", 5000, 1, "sztuka" )
            //    });

            //var result = transaction.CalculateTotalProfit();

            //Assert.AreEqual(1000, result);
        }

        [Test]
        public void CalculateTotalPrice_ValidTransaction_Success()
        {
            //var transaction = new Transaction(1, TransactionType.Purchase,
            //    new Employee { EmpoyeeID = 1, FirstName = "Imię", LastName = "Nazwisko" },
            //    new Customer { }, new DateTime { }, new List<Item> {
            //        new Item(1, "Łódka", 5000, 1, "sztuka" ),
            //        new Item(1, "Łódka", 5000, 1, "sztuka" )
            //    });
            //var result = transaction.CalculateTotalPrice();

            //Assert.AreEqual(10000, result);
        }
    }
}
