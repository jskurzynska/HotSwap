using Microsoft.AspNetCore.Mvc;

namespace HotSwap.Controllers
{
    public class ItemsController : Controller
    {
        private readonly IItemsRepository _itemsRepository;

        public ItemsController(IItemsRepository itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }

        [HttpGet("api/items")]
        public IActionResult GetItems()
        {
            return Ok(_itemsRepository.GetAllItems());
        }

        [HttpGet("api/items/{id}")]
        public IActionResult GetItem(int id)
        {
            var item = _itemsRepository.GetItemById(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }
    }
}
