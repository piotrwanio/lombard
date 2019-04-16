using Lombard.DAL.Models;
using Lombard.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            var itemVal = (from i in _context.Items
                           where i.ItemId == item.ItemId
                           select i).FirstOrDefault();

            if (itemVal == null)
            {
                throw new Exception("Database doesn't contains this item");
            }

            try
            {
                _context.Items.Remove(item);
                _context.SaveChanges();

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public Item GetItemById(int id)
        {
            try
            {
                var item = (from i in _context.Items
                            where i.ItemId == id
                            select i).FirstOrDefault();
                return item;
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        public IList<Item> GetItems()
        {
            try
            {
                IList<Item> items = (from i in _context.Items
                                     select i)?.ToList();
                return items;
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        public bool UpdateItem(Item item)
        {
            _context.Items.Update(item);
            return true;
        }
    }
}
