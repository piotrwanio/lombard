using System.Collections.Generic;
using Lombard.DAL.Models;

namespace Lombard.BLL.Services
{
    public interface IReportService
    {
        IList<Item> GetMissingItems();
        IList<Item> GetStockStatus();
        decimal GetTotalProfit();
        decimal GetTotalRotation();
    }
}