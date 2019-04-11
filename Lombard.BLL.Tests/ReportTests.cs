using Lombard.BLL.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lombard.BLL.Tests
{
    [TestFixture]
    class ReportTests
    {
        [Test]
        public void TestEmptyStock()
        {
            var report = new Report(1,200,300,0);
            int result = report.MissingStockItem(0);
            Assert.AreEqual(result, 0);
        }

    }
}
