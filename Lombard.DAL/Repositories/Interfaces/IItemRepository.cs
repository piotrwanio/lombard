using Lombard.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lombard.DAL.Repositories.Interfaces
{
    public interface IItemRepository
    {
        bool AddItem(Item item);
        List<Item> GetItems();
        Item GetItemById(int id);
        bool UpdateItem(Item item);
        bool DeleteItem(Item item);
    }
}
