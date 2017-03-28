using System.Linq;
using HotSwap.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HotSwap.Controllers
{
    public class ItemsController : Controller
    {
        private IItemsRepository _itemsRepository;

        public ItemsController(IItemsRepository itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }

        [HttpGet("api/items")]
        public IActionResult GetItems()
        {
            return Ok(ItemsRepository.TemporaryItems.ItemDtos);
        }

        [HttpGet("api/items/{id}")]
        public IActionResult GetItem(int id)
        {
            var item = ItemsRepository.TemporaryItems.ItemDtos.FirstOrDefault(i => i.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }
    }
}
