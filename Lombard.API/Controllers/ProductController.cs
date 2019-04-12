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

        [HttpGet("get/{id}")]
        public ActionResult<Item> GetItemById(int id)
        {
            Item item = _itemRepository.GetItemById(id);
            return item;
        }
    }
}