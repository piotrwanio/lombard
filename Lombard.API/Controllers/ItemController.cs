using Lombard.BLL.Services;
using Lombard.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lombard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemProvider;

        public ItemController(IItemService itemProvider)
        {
            _itemProvider = itemProvider;
        }

        [HttpGet("{id}")]
        public ActionResult<Item> GetItemById(int id)
        {
            return _itemProvider.GetItemById(id);
        }

        [HttpDelete("{id}")]
        public ActionResult<Item> DeleteItemById(int id)
        {
            Item item = _itemProvider.GetItemById(id);
            _itemProvider.DeleteItem(item);

            return item;
        }

        [HttpGet("")]
        public ActionResult<List<Item>> GetAllItems()
        {
            return _itemProvider.GetItems();
        }
    }
}