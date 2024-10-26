using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingApp.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialProductMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    OriginalPrice = table.Column<double>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DetailedDescription = table.Column<string>(type: "TEXT", nullable: false),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false),
                    Reviews = table.Column<int>(type: "INTEGER", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "DetailedDescription", "ImageUrl", "Name", "OriginalPrice", "Price", "Reviews" },
                values: new object[,]
                {
                    { 1, "Fashion", "Black Bella Canvas, T-Shirt, Male Model, Lifestyle Outdoor.", "Black Bella Canvas, T-Shirt, Male Model, Lifestyle Outdoor. Material: 100% Cotton, Size: L.", "https://via.placeholder.com/150", "T-Shirt", 39.0, 19.0, 13 },
                    { 2, "Fashion", "Blue, 100% cotton drill, 5 pockets.", "Blue, 100% cotton drill, 5 pockets. Material: 100% Cotton, Size: M.", "https://via.placeholder.com/150", "Blue Drill Jeans", 150.0, 118.0, 26 },
                    { 3, "Accessories", "Genuine Leather, nice looking accessory.", "Genuine Leather, nice looking accessory. Material: Genuine Leather, Size: Adjustable.", "https://via.placeholder.com/150", "Leather Arm Band", 45.0, 23.0, 18 },
                    { 4, "Fashion", "Comfortable, stylish hoodie with a kangaroo pocket.", "Comfortable, stylish hoodie with a kangaroo pocket.Material: 80% Cotton, 20% Polyester, Size: M.", "https://via.placeholder.com/150", "Red Hoodie", 50.0, 30.0, 12 },
                    { 5, "Footwear", "Classic white sneakers for everyday use.", "Classic white sneakers for everyday use. Material: Synthetic Leather, Size: 42.", "https://via.placeholder.com/150", "White Sneakers", 100.0, 75.0, 17 },
                    { 6, "Fashion", "Stylish black leather jacket with zipper pockets.", "Stylish black leather jacket with zipper pockets. Material: Genuine Leather, Size: L.", "https://via.placeholder.com/150", "Black Leather Jacket", 200.0, 150.0, 5 },
                    { 7, "Fashion", "Stylish black leather jacket with zipper pockets.", "Stylish black leather jacket with zipper pockets. Material: Genuine Leather, Size: L.", "https://via.placeholder.com/150", "Black Leather Jacket", 200.0, 150.0, 5 },
                    { 8, "Fashion", "Casual blue baseball cap with adjustable strap.", "Casual blue baseball cap with adjustable strap. Material: 100% Cotton, One size fits all.", "https://via.placeholder.com/150", "Blue Baseball Cap", 20.0, 12.0, 35 },
                    { 9, "Fashion", "Comfortable grey sweatpants with drawstring waist.", "Comfortable grey sweatpants with drawstring waist. Material: 60% Cotton, 40% Polyester, Size: M.", "https://via.placeholder.com/150", "Grey Sweatpants", 35.0, 25.0, 3 },
                    { 10, "Footwear", "Elegant black dress shoes for formal occasions.", "Elegant black dress shoes for formal occasions. Material: Genuine Leather, Size: 44.", "https://via.placeholder.com/150", "Black Dress Shoes", 120.0, 80.0, 67 },
                    { 11, "Fashion", "Classic white dress shirt for office wear.", "Classic white dress shirt for office wear. Material: 100% Cotton, Size: L.", "https://via.placeholder.com/150", "White Dress Shirt", 50.0, 35.0, 21 },
                    { 12, "Accessories", "Durable black backpack with multiple compartments.", "Durable black backpack with multiple compartments. Material: Nylon, Capacity: 20L.", "https://via.placeholder.com/150", "Black Backpack", 60.0, 40.0, 75 },
                    { 13, "Fashion", "Warm grey beanie for cold weather.", "Warm grey beanie for cold weather. Material: Wool Blend, One size fits all.", "https://via.placeholder.com/150", "Grey Beanie", 25.0, 15.0, 18 },
                    { 14, "Accessories", "Classic black belt with silver buckle.", "Classic black belt with silver buckle. Material: Genuine Leather, Size: 34.", "https://via.placeholder.com/150", "Black Belt", 30.0, 20.0, 39 },
                    { 15, "Accessories", "Brown leather belt with a steel buckle.", "Brown leather belt with a steel buckle.", "https://via.placeholder.com/150", "Leather Belt", 55.0, 35.0, 17 },
                    { 16, "Accessories", "Genuine leather wallet with multiple compartments.", "Genuine leather wallet with multiple compartments.", "https://via.placeholder.com/150", "Leather Wallet", 100.0, 65.0, 75 },
                    { 17, "Watches", "Waterproof digital watch with multiple functions.", "Waterproof digital watch with multiple functions.", "https://via.placeholder.com/150", "Digital Watch", 100.0, 65.0, 39 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
