using Microsoft.EntityFrameworkCore;
using ShoppingApp.Services.AuthAPI.Models;

namespace ShoppingApp.Services.AuthAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 1,
                FirstName = "Dan",
                LastName = "Barazani",
                Email = "danbarazani@gmail.com",
                Password = "P@ssw0rd", 
                ShippingAddress = "Alabama, Conerax, Delta ave. 125/3"
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 2,
                FirstName = "James",
                LastName = "Palimio",
                Email = "jamespalimio@gmail.com",
                Password = "P@ssw0rd", 
                ShippingAddress = "Washington DC, Arlington, Mormon ave. 745"
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 3,
                FirstName = "Virgo",
                LastName = "Zaleppio",
                Email = "virgozalepio@gmail.com",
                Password = "P@ssw0rd", 
                ShippingAddress = "Talasa, Rolton, South ave. 33"
            });
        }
    }
}
