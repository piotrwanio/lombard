using Lombard.BLL.ViewModels;
using Lombard.DAL.Models;
using Lombard.DAL.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

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


        public IList<StockViewModel> GetItems()
        {
            return _itemRepository.GetItems().GroupBy(i => i.Name)
                 .Select(x => new StockViewModel
                 {
                     Name = x.Key,
                     Quantity = x.Select(y => y.Quantity).Sum()
                 })
                 .ToList();
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
