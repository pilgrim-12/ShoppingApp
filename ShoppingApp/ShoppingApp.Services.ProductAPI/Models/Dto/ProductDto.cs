namespace ShoppingApp.Services.ProductAPI.Models.Dto
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double OriginalPrice { get; set; }
        public string Description { get; set; }
        public string DetailedDescription { get; set; }
        public string CategoryName { get; set; }
        public int? Reviews { get; set; }
        public string? ImageUrl { get; set; }  
    }
}
