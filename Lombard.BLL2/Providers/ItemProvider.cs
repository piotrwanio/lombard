using Lombard.DAL.Models;
using Lombard.DAL.Repositories.Interfaces;
using System.Collections.Generic;

namespace Lombard.BLL.Providers
{
    public class ItemProvider : IItemProvider
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
            return _itemRepository.GetItems();
        }
    }
}
