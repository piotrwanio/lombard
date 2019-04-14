using Lombard.DAL;
using Lombard.DAL.Models;
using Lombard.DAL.Repositories.Implementations;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;

namespace Lombard.DAL.Tests
{
    public class ItemRepositoryTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddItem_CorrectItem_Success()
        {
            //arrange
            EFDbContext context = new EFDbContext();
            ItemRepository itemRepository = new ItemRepository(context);
            Item item = new Item {
                Name = "ooo",
                PurchasePrice = 888,
                Quantity = 8
            };

            //act
            var result = itemRepository.AddItem(item);

            //asserts
            Assert.AreEqual(true, result);
        }
    }


}