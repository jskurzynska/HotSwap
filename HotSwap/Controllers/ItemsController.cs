using HotSwap.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace HotSwap.Controllers
{
    public class ItemsController : Controller
    {
        [HttpGet("api/item")]
        public JsonResult GetItem()
        {
            return new JsonResult(new ItemDto{ Id = 1, Name = "first"});
        }
    }
}
