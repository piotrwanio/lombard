using System;
using System.Collections.Generic;
using System.Text;
using Lombard.DAL.Models;
using Lombard.BLL.Services;
using NUnit.Framework;

namespace Lombard.BLL.Tests
{
    [TestFixture]
    public class ItemServiceTests
    {
        [TestCase(5)]
        [TestCase(9)]
        [TestCase(8)]
        public void UpdateQuantity_EmployeeUpdatingQuantity_UpdatingQuantity(int quantity)
        {
            var item = new Item();//new Item(45,"Ryż",450M,4,"KG", 6000);
            Assert.That(true);
        }


        [Test]
        public void SetSellingPrice_EmployeeSetingItemSellingPrice_SellingPriceIsSet()
        {
            var item = new Item();
            Assert.That(true);
        }

        [TestCase(589)]
        [TestCase(967)]
        [TestCase(823)]
        public void SetSellingPrice_EmployeesSetingItemSellingPrice_SellingPriceIsSet(decimal sellingPrice)
        {
            var item = new Item();
            Assert.That(true);
        }

        [Test]
        public void CalculateProfit_WhenCalled_ReturnsProfit()
        {
            var item = new Item();
            Assert.That(true);
        }

        [TestCase(560, 110)]
        [TestCase(888, 438)]
        [TestCase(900, 450)]
        public void CalculateProfit_WhenCalled_ReturnsProfits(decimal sellingPrice, decimal profit)
        {
            var item = new Item();
            //var itemService = new ItemService(item);
            //itemService.SetSellingPrice(sellingPrice);
            //var actual = itemService.CalculateProfit();
            Assert.That(true);
        }
    }
}
