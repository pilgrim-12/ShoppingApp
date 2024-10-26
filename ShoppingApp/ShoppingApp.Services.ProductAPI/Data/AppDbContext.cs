using Microsoft.EntityFrameworkCore;
using ShoppingApp.Services.ProductAPI.Models;

namespace ShoppingApp.Services.ProductAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "T-Shirt",
                Description = "Black Bella Canvas, T-Shirt, Male Model, Lifestyle Outdoor.",
                DetailedDescription = "Black Bella Canvas, T-Shirt, Male Model, Lifestyle Outdoor. Material: 100% Cotton, Size: L.",
                Price = 19.00,
                OriginalPrice = 39.00,
                ImageUrl = "https://via.placeholder.com/150",
                CategoryName = "Fashion",
                Reviews = 13
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Blue Drill Jeans",
                Description = "Blue, 100% cotton drill, 5 pockets.",
                DetailedDescription = "Blue, 100% cotton drill, 5 pockets. Material: 100% Cotton, Size: M.",
                Price = 118.00,
                OriginalPrice = 150.00,
                ImageUrl = "https://via.placeholder.com/150",
                CategoryName = "Fashion",
                Reviews = 26
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Leather Arm Band",
                Description = "Genuine Leather, nice looking accessory.",
                DetailedDescription = "Genuine Leather, nice looking accessory. Material: Genuine Leather, Size: Adjustable.",
                Price = 23.00,
                OriginalPrice = 45.00,
                ImageUrl = "https://via.placeholder.com/150",
                CategoryName = "Accessories",
                Reviews = 18
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Red Hoodie",
                Description = "Comfortable, stylish hoodie with a kangaroo pocket.",
                DetailedDescription = "Comfortable, stylish hoodie with a kangaroo pocket.Material: 80% Cotton, 20% Polyester, Size: M.",
                Price = 30.00,
                OriginalPrice = 50.00,
                ImageUrl = "https://via.placeholder.com/150",
                CategoryName = "Fashion",
                Reviews = 12
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "White Sneakers",
                Description = "Classic white sneakers for everyday use.",
                DetailedDescription = "Classic white sneakers for everyday use. Material: Synthetic Leather, Size: 42.",
                Price = 75.00,
                OriginalPrice = 100.00,
                ImageUrl = "https://via.placeholder.com/150",
                CategoryName = "Footwear",
                Reviews = 17
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Black Leather Jacket",
                Description = "Stylish black leather jacket with zipper pockets.",
                DetailedDescription = "Stylish black leather jacket with zipper pockets. Material: Genuine Leather, Size: L.",
                Price = 150.00,
                OriginalPrice = 200.00,
                ImageUrl = "https://via.placeholder.com/150",
                CategoryName = "Fashion",
                Reviews = 5
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 7,
                Name = "Black Leather Jacket",
                Description = "Stylish black leather jacket with zipper pockets.",
                DetailedDescription = "Stylish black leather jacket with zipper pockets. Material: Genuine Leather, Size: L.",
                Price = 150.00,
                OriginalPrice = 200.00,
                ImageUrl = "https://via.placeholder.com/150",
                CategoryName = "Fashion",
                Reviews = 5
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 8,
                Name = "Blue Baseball Cap",
                Description = "Casual blue baseball cap with adjustable strap.",
                DetailedDescription = "Casual blue baseball cap with adjustable strap. Material: 100% Cotton, One size fits all.",
                Price = 12.00,
                OriginalPrice = 20.00,
                ImageUrl = "https://via.placeholder.com/150",
                CategoryName = "Fashion",
                Reviews = 35
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 9,
                Name = "Grey Sweatpants",
                Description = "Comfortable grey sweatpants with drawstring waist.",
                DetailedDescription = "Comfortable grey sweatpants with drawstring waist. Material: 60% Cotton, 40% Polyester, Size: M.",
                Price = 25.00,
                OriginalPrice = 35.00,
                ImageUrl = "https://via.placeholder.com/150",
                CategoryName = "Fashion",
                Reviews = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 10,
                Name = "Black Dress Shoes",
                Description = "Elegant black dress shoes for formal occasions.",
                DetailedDescription = "Elegant black dress shoes for formal occasions. Material: Genuine Leather, Size: 44.",
                Price = 80.00,
                OriginalPrice = 120.00,
                ImageUrl = "https://via.placeholder.com/150",
                CategoryName = "Footwear",
                Reviews = 67
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 11,
                Name = "White Dress Shirt",
                Description = "Classic white dress shirt for office wear.",
                DetailedDescription = "Classic white dress shirt for office wear. Material: 100% Cotton, Size: L.",
                Price = 35.00,
                OriginalPrice = 50.00,
                ImageUrl = "https://via.placeholder.com/150",
                CategoryName = "Fashion",
                Reviews = 21
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 12,
                Name = "Black Backpack",
                Description = "Durable black backpack with multiple compartments.",
                DetailedDescription = "Durable black backpack with multiple compartments. Material: Nylon, Capacity: 20L.",
                Price = 40.00,
                OriginalPrice = 60.00,
                ImageUrl = "https://via.placeholder.com/150",
                CategoryName = "Accessories",
                Reviews = 75
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 13,
                Name = "Grey Beanie",
                Description = "Warm grey beanie for cold weather.",
                DetailedDescription = "Warm grey beanie for cold weather. Material: Wool Blend, One size fits all.",
                Price = 15.00,
                OriginalPrice = 25.00,
                ImageUrl = "https://via.placeholder.com/150",
                CategoryName = "Fashion",
                Reviews = 18
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 14,
                Name = "Black Belt",
                Description = "Classic black belt with silver buckle.",
                DetailedDescription = "Classic black belt with silver buckle. Material: Genuine Leather, Size: 34.",
                Price = 20.00,
                OriginalPrice = 30.00,
                ImageUrl = "https://via.placeholder.com/150",
                CategoryName = "Accessories",
                Reviews = 39
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 15,
                Name = "Leather Belt",
                Description = "Brown leather belt with a steel buckle.",
                DetailedDescription = "Brown leather belt with a steel buckle.",
                Price = 35.00,
                OriginalPrice = 55.00,
                ImageUrl = "https://via.placeholder.com/150",
                CategoryName = "Accessories",
                Reviews = 17
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 16,
                Name = "Leather Wallet",
                Description = "Genuine leather wallet with multiple compartments.",
                DetailedDescription = "Genuine leather wallet with multiple compartments.",
                Price = 65.00,
                OriginalPrice = 100.00,
                ImageUrl = "https://via.placeholder.com/150",
                CategoryName = "Accessories",
                Reviews = 75
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 17,
                Name = "Digital Watch",
                Description = "Waterproof digital watch with multiple functions.",
                DetailedDescription = "Waterproof digital watch with multiple functions.",
                Price = 65.00,
                OriginalPrice = 100.00,
                ImageUrl = "https://via.placeholder.com/150",
                CategoryName = "Watches",
                Reviews = 39
            }); 
        }
    }
}
