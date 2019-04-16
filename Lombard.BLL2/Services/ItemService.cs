using Lombard.DAL.Models;
using Lombard.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace Lombard.BLL.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
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


        public void UpdateQuantity(int quantity)
        {
            throw new NotImplementedException();
        }

        public IList<Item> GetItems()
        {
            return _itemRepository.GetItems();
        }

        public string UpdateItem(Item item)
        {
            if (_itemRepository.UpdateItem(item))
            {
                return "Przedmiot został zaktualizowany";
            }
            return "Błąd podczas aktualizacji przedmiotu";
        }
    }
}
