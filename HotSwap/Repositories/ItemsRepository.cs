using System.Collections.Generic;
using System.Linq;
using HotSwap.DTOs;

namespace HotSwap.Repositories
{
    public class ItemsRepository : IItemsRepository
    {
        public List<ItemDto> ItemDtos { get; set; }

        public ItemsRepository()
        {
            ItemDtos = new List<ItemDto>
            {
                new ItemDto {Id = 1, Name="Dress", Description = "Black dress", ItemCategoryId = 1, ItemStatusId = 1},
                new ItemDto {Id = 2, Name="Tell no one", Description = "Harlan Coben book", ItemCategoryId = 2, ItemStatusId = 2},
                new ItemDto {Id = 3, Name="LOL", Description = "Just LOL", ItemCategoryId = 4, ItemStatusId = 2}
            };
        }

        public List<ItemDto> GetAllItems()
        {
            return ItemDtos;
        }

        public ItemDto GetItemById(int id)
        {
            return ItemDtos.FirstOrDefault(i => i.Id == id);
        }
    }
}
