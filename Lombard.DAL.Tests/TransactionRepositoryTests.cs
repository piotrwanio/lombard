using Lombard.DAL.Models;
using Lombard.DAL.Repositories.Implementations;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lombard.DAL.Tests
{
    public class TransactionRepositoryTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddTransaction_CorrectTransaction_Success()
        {
            //arrange
            EFDbContext context = new EFDbContext();
            TransactionRepository transactionRepository = new TransactionRepository(context); 
            ItemRepository  itemRepository = new ItemRepository(context); 

            Item item = new Item
            {
                Name = "ooo",
                PurchasePrice = 888,
                Quantity = 8
            };

            Item item2 = new Item
            {
                ItemId = 1,
                Name = "AAA",
                PurchasePrice = 888,
                Quantity = 8
            };

            Item item3 = context.Items.Find(item2.ItemId);

            Transaction transaction = new Transaction
            {
                Items = new List<Item> { item, item3 },
                Customer = new Customer { FirstName = "ss"},
                Employee = new Employee { FirstName = "ss"}
            };

            //act
            var result = transactionRepository.AddTransaction(transaction);

            var delete = transactionRepository.DeleteTransaction(transaction);

            //asserts
            Assert.AreEqual(true, result);
        }

        [Test]
        public void GetTransactions_All_Success()
        {
            //arrange
            EFDbContext context = new EFDbContext();
            TransactionRepository transactionRepository = new TransactionRepository(context);

            //act
            var result = transactionRepository.GetTransactions();

            //asserts
            Assert.NotNull(result);
        }
    }

}
