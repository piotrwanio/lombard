using Lombard.DAL.Models;
using System.Collections.Generic;

namespace Lombard.BLL.Services
{
    public interface IItemService
    {
        void DeleteItem(Item item);
        Item GetItemById(int id);
        IList<Item> GetItems();
        string UpdateItem(Item item);
    }
}