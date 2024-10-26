using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingApp.Services.AuthAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    ShippingAddress = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "Password", "ShippingAddress" },
                values: new object[,]
                {
                    { 1, "danbarazani@gmail.com", "Dan", "Barazani", "P@ssw0rd", "Alabama, Conerax, Delta ave. 125/3" },
                    { 2, "jamespalimio@gmail.com", "James", "Palimio", "P@ssw0rd", "Washington DC, Arlington, Mormon ave. 745" },
                    { 3, "virgozalepio@gmail.com", "Virgo", "Zaleppio", "P@ssw0rd", "Talasa, Rolton, South ave. 33" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
