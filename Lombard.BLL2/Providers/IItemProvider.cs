using System.Collections.Generic;
using Lombard.DAL.Models;

namespace Lombard.BLL.Providers
{
    public interface IItemProvider
    {
        void DeleteItem(Item item);
        Item GetItemById(int id);
        List<Item> GetItems();
    }
}