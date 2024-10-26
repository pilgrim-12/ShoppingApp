﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoppingApp.Services.AuthAPI.Data;

#nullable disable

namespace ShoppingApp.Services.AuthAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0-rc.2.24474.1");

            modelBuilder.Entity("ShoppingApp.Services.AuthAPI.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "danbarazani@gmail.com",
                            FirstName = "Dan",
                            LastName = "Barazani",
                            Password = "P@ssw0rd",
                            ShippingAddress = "Alabama, Conerax, Delta ave. 125/3"
                        },
                        new
                        {
                            UserId = 2,
                            Email = "jamespalimio@gmail.com",
                            FirstName = "James",
                            LastName = "Palimio",
                            Password = "P@ssw0rd",
                            ShippingAddress = "Washington DC, Arlington, Mormon ave. 745"
                        },
                        new
                        {
                            UserId = 3,
                            Email = "virgozalepio@gmail.com",
                            FirstName = "Virgo",
                            LastName = "Zaleppio",
                            Password = "P@ssw0rd",
                            ShippingAddress = "Talasa, Rolton, South ave. 33"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
