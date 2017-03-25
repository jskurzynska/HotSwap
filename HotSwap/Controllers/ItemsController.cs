using System.Linq;
using HotSwap.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HotSwap.Controllers
{
    public class ItemsController : Controller
    {
        [HttpGet("api/items")]
        public IActionResult GetItem()
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
