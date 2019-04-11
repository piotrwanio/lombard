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
    }
}
