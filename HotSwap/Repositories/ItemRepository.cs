using System.Collections.Generic;
using HotSwap.DTOs;

namespace HotSwap.Repositories
{
    public class ItemRepository
    {
        public static ItemRepository ItemsRepository { get; set; } = new ItemRepository();
        public List<ItemDto> ItemDtos { get; set; }

        public ItemRepository()
        {
            ItemDtos = new List<ItemDto>
            {
                new ItemDto {Id = 1, Name="Dress", Description = "Black dress", ItemCategoryId = 1, ItemStatusId = 1},
                new ItemDto {Id = 2, Name="Tell no one", Description = "Harlan Coben book", ItemCategoryId = 2, ItemStatusId = 2},
                new ItemDto {Id = 3, Name="LOL", Description = "Just LOL", ItemCategoryId = 4, ItemStatusId = 2}
            };
        }
    }
}
