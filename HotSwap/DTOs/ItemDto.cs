using System.ComponentModel.DataAnnotations;

namespace HotSwap.DTOs
{
    public class ItemDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public int ItemStatusId { get; set; }
        [Required]
        public int ItemCategoryId { get; set; }
        public string OwnerId { get; set; }
        public UserDto Owner { get; set; }
    }
}
