using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Services.ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(1, 10000)]
        [Required]
        public double Price { get; set; }
        [Range(1, 10000)]
        [Required]
        public double OriginalPrice { get; set; }
        [Required]
        public string Description { get; set; }
        public string DetailedDescription { get; set; }
        public string CategoryName { get; set; }
        public int? Reviews { get; set; }
        public string? ImageUrl { get; set; } 
    }
}
