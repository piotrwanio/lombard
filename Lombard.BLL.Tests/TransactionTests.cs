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
        public void CalculateTotalProfit_Success()
        {
            //arrange
            Transaction transaction = new Transaction(1, TransactionType.Purchase, 
                new Employee { EmpoyeeID = 1, FirstName = "Imię", LastName = "Nazwisko"},
                new Customer { }, new DateTime { });

            //act
            var result = transaction.CalculateTotalProfit();

            //asserts
            Assert.AreEqual(1000, result);
        }
    }
}
