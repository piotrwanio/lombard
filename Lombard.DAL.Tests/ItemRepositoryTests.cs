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

        [Test]
        public void Delete_CorrectItem_Success()
        {
            //arrange
            EFDbContext context = new EFDbContext();
            ItemRepository itemRepository = new ItemRepository(context);
            Item item = new Item
            {
                Name = "ooo",
                PurchasePrice = 888,
                Quantity = 8
            };

            //act
            itemRepository.AddItem(item);
            var result = itemRepository.DeleteItem(item);

            //asserts
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Delete_InvalidItem_Success()
        {
            //arrange
            EFDbContext context = new EFDbContext();
            ItemRepository itemRepository = new ItemRepository(context);
            Item item = new Item
            {
                Name = "ooo",
                PurchasePrice = 888,
                Quantity = 8
            };
            Item item2 = new Item
            {
                Name = "ooo",
                PurchasePrice = 888,
                Quantity = 8
            };

            //act
            itemRepository.AddItem(item);

            //asserts
            Assert.Throws<Exception>(() => { itemRepository.DeleteItem(item2); });
        }

        [Test]
        public void Update_CorrectItem_Success()
        {
            //arrange
            EFDbContext context = new EFDbContext();
            ItemRepository itemRepository = new ItemRepository(context);
            Item item = new Item
            {
                Name = "ooo",
                PurchasePrice = 888,
                Quantity = 8
            };

            //act
            itemRepository.AddItem(item);
            var itemFromDb = itemRepository.GetItemById(item.ItemId.Value);

            itemFromDb.Name = "testesttest";
            var result = itemRepository.UpdateItem(itemFromDb);

            var test = itemRepository.GetItemById(itemFromDb.ItemId.Value);

            //asserts
            Assert.AreEqual("testesttest", test.Name);
        }
    }


}