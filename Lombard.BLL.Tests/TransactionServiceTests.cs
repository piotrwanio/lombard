using Lombard.DAL.Models;
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
            var transaction = new Transaction();
               

            var transactionService = new TransactionService(transaction);
            var expected = transactionService.CalculateTotalProfit();

            Assert.AreEqual(1000, expected);
        }

        [Test]
        public void CalculateTotalPrice_ValidTransaction_Success()
        {
            var transaction = new Transaction();

            var transactionService = new TransactionService(transaction);
            var expected = transactionService.CalculateTotalPrice();

            Assert.AreEqual(12000, expected);
        }
    }
}
