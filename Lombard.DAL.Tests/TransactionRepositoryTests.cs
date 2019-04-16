using Lombard.DAL.Models;
using Lombard.DAL.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
            EFDbContext context = new EFDbContext(CreateNewContextOptions());
            TransactionRepository transactionRepository = new TransactionRepository(context);
            ItemRepository itemRepository = new ItemRepository(context);

        //    Item item = new Item
        //    {
        //        Name = "ooo",
        //        PurchasePrice = 888,
        //        Quantity = 8
        //    };

            Item item2 = new Item
            {
                ItemId = 1,
                Name = "AAA",
                PurchasePrice = 888,
                Quantity = 8
            };

            Transaction transaction = new Transaction
            {
                Items = new List<Item> { item, item2 },
            };

        //    Transaction transaction2 = new Transaction
        //    {
        //        Items = new List<Item> { item2 }
        //    };

        //    //act
        //    transactionRepository.AddTransaction(transaction);
        //    transactionRepository.AddTransaction(transaction2);

        //    var all = transactionRepository.GetTransactions();

        //    //asserts
        //    Assert.AreEqual(2, all.Count);
        //}

        //[Test]
        //public void AddTransaction_Null_NullArgException()
        //{
        //    //arrange
        //    EFDbContext context = new EFDbContext(CreateNewContextOptions());
        //    TransactionRepository transactionRepository = new TransactionRepository(context);

        //    //act and assert
        //    Assert.Throws<ArgumentNullException>(() => { transactionRepository.AddTransaction(null); });
        //}

        [Test]
        public void GetTransactions_All_Success()
        {
            //arrange
            EFDbContext context = new EFDbContext(CreateNewContextOptions());
            TransactionRepository transactionRepository = new TransactionRepository(context);

        //    //act

            var transactions = new List<Transaction>
            {
                new Transaction {
                       TransactionId = 1,
                       TransactionDate = new DateTime(2019,11,12),
                       Items = new List<Item>()
                        },
                new Transaction {
                        TransactionId = 2,
                        TransactionDate = new DateTime(2018,11,12),
                        Items = new List<Item>()
                        },
                new Transaction {
                        TransactionId = 3,
                       TransactionDate = new DateTime(2017,11,12),
                        Items = new List<Item>()
                        },
            };

        //    transactions.ForEach(t => transactionRepository.AddTransaction(t));
        //    var result = transactionRepository.GetTransactions();

            //asserts
            Assert.NotNull(result);
        }

        //private static DbContextOptions<EFDbContext> CreateNewContextOptions()
        //{
        //    // The key to keeping the databases unique and not shared is 
        //    // generating a unique db name for each.
        //    string dbName = Guid.NewGuid().ToString();

        //    // Create a fresh service provider, and therefore a fresh 
        //    // InMemory database instance.
        //    var serviceProvider = new ServiceCollection()
        //        .AddEntityFrameworkInMemoryDatabase()
        //        .BuildServiceProvider();

        //    // Create a new options instance telling the context to use an
        //    // InMemory database and the new service provider.
        //    var builder = new DbContextOptionsBuilder<EFDbContext>();
        //    builder.UseInMemoryDatabase(dbName)
        //           .UseInternalServiceProvider(serviceProvider);

        //    return builder.Options;
        //}
    }

}
