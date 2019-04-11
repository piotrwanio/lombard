using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Lombard.BLL.Tests
{
    [TestFixture]
    public class ItemTests
    {
        [TestCase(5)]
        [TestCase(9)]
        [TestCase(8)]
        public void UpdateQuantity_EmployeeUpdatingQuantity_UpdatingQuantity(int quantity)
        {
            var item = new Item(45,"Ryż",450M,4,"KG");
            item.UpdateQuantity(quantity);
            Assert.That(item.Quantity, Is.EqualTo(quantity));
        }


        [Test]
        public void SetSellingPrice_EmployeeSetingItemSellingPrice_SellingPriceIsSet()
        {
            var item = new Item(45, "Ryż", 450M, 4, "KG");
            var expected = 560M;
            item.SetSellingPrice(expected);
            Assert.That(item.SellingPrice, Is.EqualTo(expected));
        }

        [TestCase(589)]
        [TestCase(967)]
        [TestCase(823)]
        public void SetSellingPrice_EmployeesSetingItemSellingPrice_SellingPriceIsSet(decimal sellingPrice)
        {
            var item = new Item(45, "Ryż", 450M, 4, "KG");
            item.SetSellingPrice(sellingPrice);
            Assert.That(item.SellingPrice, Is.EqualTo(sellingPrice));
        }

        [Test]
        public void CalculateProfit_WhenCalled_ReturnsProfit()
        {
            var item = new Item(45, "Ryż", 450M, 4, "KG");
            item.SetSellingPrice(455);
            var expected = 5M;
            var actual = item.CalculateProfit();
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(560,110)]
        [TestCase(888,438)]
        [TestCase(900,450)]
        public void CalculateProfit_WhenCalled_ReturnsProfits(decimal sellingPrice, decimal profit)
        {
            var item = new Item(45, "Ryż", 450M, 4, "KG");
            item.SetSellingPrice(sellingPrice);
            var actual = item.CalculateProfit();
            Assert.That(actual, Is.EqualTo(profit));
        }
    }
}
