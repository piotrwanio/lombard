using Lombard.DAL;
using Lombard.DAL.Models;
using Lombard.DAL.Repositories.Implementations;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Lombard.DAL.Tests
{
    public class ItemRepositoryTests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void AddItem_CorrectItem_Success()
        //{
        //    //arrange
        //    EFDbContext context = new EFDbContext();
        //    ItemRepository itemRepository = new ItemRepository(context);
        //    Item item = new Item
        //    {
        //        Name = "ooo",
        //        PurchasePrice = 888,
        //        Quantity = 8
        //    };

        //    var items = new List<Item>
        //    {
        //        new Item {
        //                Name = "ooo",
        //                PurchasePrice = 888,
        //                Quantity = 8
        //                },
        //        new Item {
        //                Name = "asd",
        //                PurchasePrice = 666,
        //                Quantity = 6
        //                },
        //        new Item {
        //                Name = "qwe",
        //                PurchasePrice = 555,
        //                Quantity = 5
        //                },
        //        new Item
        //        {
        //                Name = "zxc",
        //                PurchasePrice = 999,
        //                Quantity = 9
        //        },
        //        new Item
        //        {
        //                Name = "fgh",
        //                PurchasePrice = 111,
        //                Quantity = 1
        //        },
        //        new Item {
        //                Name = "rty",
        //                PurchasePrice = 777,
        //                Quantity = 7
        //        }
        //    };

        //    items.ForEach(i => itemRepository.AddItem(i));


        //    //act
        //    var result = itemRepository.AddItem(item);

        //    //asserts
        //    Assert.AreEqual(true, result);
        //}

        //[Test]
        //public void Delete_CorrectItem_Success()
        //{
        //    //arrange
        //    EFDbContext context = new EFDbContext();
        //    ItemRepository itemRepository = new ItemRepository(context);
        //    Item item = new Item
        //    {
        //        Name = "ooo",
        //        PurchasePrice = 888,
        //        Quantity = 8
        //    };

        //    //act
        //    itemRepository.AddItem(item);
        //    var result = itemRepository.DeleteItem(item);

        //    //asserts
        //    Assert.AreEqual(true, result);
        //}

        //[Test]
        //public void Delete_InvalidItem_Success()
        //{
        //    //arrange
        //    EFDbContext context = new EFDbContext();
        //    ItemRepository itemRepository = new ItemRepository(context);
        //    Item item = new Item
        //    {
        //        Name = "ooo",
        //        PurchasePrice = 888,
        //        Quantity = 8
        //    };
        //    Item item2 = new Item
        //    {
        //        Name = "ooo",
        //        PurchasePrice = 888,
        //        Quantity = 8
        //    };

        //    //act
        //    itemRepository.AddItem(item);

        //    //asserts
        //    Assert.Throws<Exception>(() => { itemRepository.DeleteItem(item2); });
        //}

        //[Test]
        //public void Update_CorrectItem_Success()
        //{
        //    //arrange
        //    EFDbContext context = new EFDbContext();
        //    ItemRepository itemRepository = new ItemRepository(context);
        //    Item item = new Item
        //    {
        //        Name = "ooo",
        //        PurchasePrice = 888,
        //        Quantity = 8
        //    };

        //    //act
        //    itemRepository.AddItem(item);
        //    var itemFromDb = itemRepository.GetItemById(item.ItemId.Value);

        //    itemFromDb.Name = "testesttest";
        //    var result = itemRepository.UpdateItem(itemFromDb);

        //    var test = itemRepository.GetItemById(itemFromDb.ItemId.Value);

        //    //asserts
        //    Assert.AreEqual("testesttest", test.Name);
        //}
    }


}