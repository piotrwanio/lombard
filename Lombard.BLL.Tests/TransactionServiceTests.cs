using Lombard.BLL.Models;
using Lombard.BLL.Services;
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
            var transaction = new Transaction(1, TransactionType.Purchase,
                new Employee { EmpoyeeID = 1, FirstName = "Imię", LastName = "Nazwisko" },
                new Customer { }, new DateTime { }, new List<Item> {
                    new Item(1, "Łódka", 5000, 1, "sztuka" ,6000 ),
                    new Item(1, "Łódka", 5000, 1, "sztuka",6000 )
                });

            var transactionService = new TransactionService(transaction);
            var expected = transactionService.CalculateTotalProfit();

            Assert.AreEqual(12000, expected);
        }

        [Test]
        public void CalculateTotalPrice_ValidTransaction_Success()
        {
            var transaction = new Transaction(1, TransactionType.Purchase,
                new Employee { EmpoyeeID = 1, FirstName = "Imię", LastName = "Nazwisko" },
                new Customer { }, new DateTime { }, new List<Item> {
                    new Item(1, "Łódka", 5000, 1, "sztuka",6000 ),
                    new Item(1, "Łódka", 5000, 1, "sztuka",6000 )
                });

            var transactionService = new TransactionService(transaction);
            var expected = transactionService.CalculateTotalPrice();

            Assert.AreEqual(12000, expected);
        }
    }
}
