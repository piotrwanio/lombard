using System.Collections.Generic;
using Lombard.DAL.Models;

namespace Lombard.BLL.Providers
{
    public interface IReportProvider
    {
        IList<Item> GetMissingItems();
        IList<Item> GetStockStatus();
        decimal GetTotalProfit();
        decimal GetTotalRotation();
    }
}