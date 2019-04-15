using Lombard.DAL.Models;
using Lombard.DAL.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Lombard.DAL.Repositories.Implementations
{
    public class ItemRepository : IItemRepository
    {
        private readonly EFDbContext _context;

        public ItemRepository(EFDbContext context)
        {
            _context = context;
        }

        public bool AddItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteItem(Item item)
        {
            _context.Items.Remove(item);
            _context.SaveChanges();
            return true;
        }

        public Item GetItemById(int id)
        {
            return (from i in _context.Items
                         where i.ItemId == id
                         select i).FirstOrDefault();
        }

        public List<Item> GetItems()
        {
            return (from i in _context.Items
                         select i)?.ToList();
        }

        public bool UpdateItem(Item item)
        {
            _context.Items.Update(item);
            return true;
        }
    }
}
