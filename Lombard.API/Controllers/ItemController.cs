using Lombard.BLL.Services;
using Lombard.BLL.ViewModels;
using Lombard.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Lombard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet("{id}")]
        public ActionResult<Item> GetItemById(int id)
        {
            return _itemService.GetItemById(id);
        }

        [HttpDelete("{id}")]
        public ActionResult<Item> DeleteItemById(int id)
        {
            Item item = _itemService.GetItemById(id);
            _itemService.DeleteItem(item);

            return item;
        }

        [HttpGet("")]
        public ActionResult<List<Item>> GetAllItems()
        {
            return _itemService.GetItems().ToList();
        }

        [HttpPut("")]
        public string UpdateItem(Item item)
        {
            return _itemService.UpdateItem(item);
        }
    }
}