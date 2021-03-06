﻿using Lombard.BLL.Services;
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
            var item = _itemService.GetItemById(id);
            if (item == null) return NoContent();

            return item;
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
            var items = _itemService.GetItems()?.ToList();
            if (items == null) return NoContent();

            return items;
        }

        [HttpPut("")]
        public string UpdateItem(Item item)
        {
            return _itemService.UpdateItem(item);
        }
    }
}