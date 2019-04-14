using Lombard.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Lombard.DAL.Models;

namespace Lombard.BLL.Providers
{
    public class ItemProvider
    {
        private readonly IItemRepository _itemRepository;

        public ItemProvider(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public Item GetItemById(int id)
        {
            return _itemRepository.GetItemById(id);
        }

        public void DeleteItem(Item item)
        {
           _itemRepository.DeleteItem(item);
        }

        public List<Item> GetItems()
        {
            throw new NotImplementedException();
        }
    }
}
