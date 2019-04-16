using System.Collections.Generic;
using Lombard.BLL.ViewModels;
using Lombard.DAL.Models;

namespace Lombard.BLL.Services
{
    public interface IItemService
    {
        void DeleteItem(Item item);
        Item GetItemById(int id);
        IList<StockViewModel> GetItems();
        string UpdateItem(Item item);
    }
}