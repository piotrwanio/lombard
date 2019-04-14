using Lombard.BLL.Services;
using Lombard.DAL.Models;
using Lombard.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lombard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private IItemRepository _itemRepository;
        private readonly ItemService _itemService;

        public ItemController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public ItemController(ItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet("{id}")]
        public ActionResult<Item> GetItemById(int id)
        {
            Item item = _itemRepository.GetItemById(id);
            return item;
        }

        [HttpDelete("{id}")]
        public ActionResult<Item> DeleteItemById(int id)
        {
            Item item = _itemRepository.GetItemById(id);
            _itemRepository.DeleteItem(item);

            return item;
        }

        [HttpGet("")]
        public ActionResult<List<Item>> GetAllItems(int id)
        {
            List<Item> item = _itemRepository.GetItems();
            return item;
        }

        [HttpGet("test")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "product1", "product2" };
        }
    }
}