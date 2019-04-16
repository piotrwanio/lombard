using Lombard.DAL.Models;
using System.Collections.Generic;

namespace Lombard.DAL.Repositories.Interfaces
{
    public interface IItemRepository
    {
        bool AddItem(Item item);
        IList<Item> GetItems();
        Item GetItemById(int id);
        bool UpdateItem(Item item);
        bool DeleteItem(Item item);
    }
}
