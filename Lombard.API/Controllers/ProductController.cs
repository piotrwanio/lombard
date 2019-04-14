using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lombard.BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lombard.DAL.Models;
using Lombard.DAL.Repositories.Interfaces;
using Lombard.DAL.Repositories.Implementations;

namespace Lombard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IItemRepository _itemRepository;

        public ProductController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
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

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "product1", "product2" };
        }
    }
}