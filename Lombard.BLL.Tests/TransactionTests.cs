using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lombard.BLL.Tests
{
    [TestFixture]
    public class TransactionTests
    {
        [Test]
        public void CalculateTotalProfit_ValidTransaction_Success()
        {
            //arrange
            var transaction = new Transaction(1, TransactionType.Purchase, 
                new Employee { EmpoyeeID = 1, FirstName = "Imię", LastName = "Nazwisko"},
                new Customer { }, new DateTime { }, new List<Item> {
                    new Item(1, "Łódka", 5000, 1, "sztuka" ),
                    new Item(1, "Łódka", 5000, 1, "sztuka" )
                });

            //act
            var result = transaction.CalculateTotalProfit();

            //asserts
            Assert.AreEqual(1000, result);
        }

        [Test]
        public void CalculateTotalPrice_ValidTransaction_Success()
        {
            //arrange
            var transaction = new Transaction(1, TransactionType.Purchase,
                new Employee { EmpoyeeID = 1, FirstName = "Imię", LastName = "Nazwisko" },
                new Customer { }, new DateTime { }, new List<Item> {
                    new Item(1, "Łódka", 5000, 1, "sztuka" ),
                    new Item(1, "Łódka", 5000, 1, "sztuka" )
                });

            //act
            var result = transaction.CalculateTotalPrice();

            //asserts
            Assert.AreEqual(10000, result);
        }
    }
}
