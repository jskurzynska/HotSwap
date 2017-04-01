using System.Collections.Generic;
using HotSwap.DTOs;

namespace HotSwap
{
    public interface IItemsRepository
    {
        List<ItemDto> GetAllItems();
        ItemDto GetItemById(int id);
    }
}