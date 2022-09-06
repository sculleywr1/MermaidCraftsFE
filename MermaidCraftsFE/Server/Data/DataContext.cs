using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.EntityFrameworkCore;

namespace MermaidCraftsFE.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>().HasKey(p => new { p.ProductId, p.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
                new ProductType { Id = 1, Name = "Stuffed Animal" },
                new ProductType { Id = 2, Name = "Doll Clothes" },
                new ProductType { Id = 3, Name = "Child" },
                new ProductType { Id = 4, Name = "Teen" },
                new ProductType { Id = 5, Name = "Adult" },
                new ProductType { Id = 6, Name = "Baby" },
                new ProductType { Id = 7, Name = "Twin" },
                new ProductType { Id = 8, Name = "Throw" },
                new ProductType { Id = 9, Name = "Full" },
                new ProductType { Id = 10, Name = "Queen" },
                new ProductType { Id = 11, Name = "King" }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Toys",
                    Url = "Toys"
                },
                new Category
                {
                    Id=2,
                    Name = "Clothes",
                    Url = "clothes"
                },
                new Category
                {
                    Id = 3,
                    Name = "Blankets",
                    Url = "blankets"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Teddy Bear",
                    Description = "A teddy bear made with baby soft yarn, perfect for your child",
                    ImageUrl = "https://images.squarespace-cdn.com/content/v1/5e12aa9f8c03f756cbec18fc/1607712216490-NN3SB29TDH8A2RP24HLY/classic-crochet-teddy-bear.jpg?format=1000w",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "Baby Shirt",
                    Description = "A shirt made with baby soft yarn in sizes from 2t-5t",
                    ImageUrl = "https://i.ytimg.com/vi/HohJhrZFr74/maxresdefault.jpg",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 3,
                    Title = "Baby Blanket",
                    Description = "A small blanket made with baby soft yarn, perfect for decorating baby's nursery. (disclaimer, do not use with children below 6 months. Please use safe sleep practices!)",
                    ImageUrl = "https://www.anniedesigncrochet.com/wp-content/uploads/2020/04/lace-shell-crochet-baby-blanket-9.jpg",
                    CategoryId = 3
                },
                new Product
                {
                    Id = 4,
                    Title = "Throw Blanket",
                    Description = "A decorative and comfortable throw blanket made with up to three colors of your choice",
                    ImageUrl = "https://www.mamainastitch.com/wp-content/uploads/2018/10/Fall-Easy-Beginner-blanket-pattern-crochet.jpg",
                    CategoryId = 3
                },
                new Product
                {
                    Id = 5,
                    Title = "Bed Blanket",
                    Description = "A decorative and comfortable blanket for any size bed up to three colors of your choice",
                    ImageUrl = "https://undergroundcrafter.com/wp-content/uploads/2015/03/Mod-9-Patch-Blanket-5-of-9.jpg",
                    CategoryId = 3
                }
            );
            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 1,
                    Price = 50.00m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 2,
                    Price = 30.00m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 3,
                    Price = 75.00m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 4,
                    Price = 100.00m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 5,
                    Price = 125.00m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 6,
                    Price = 50.00m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 7,
                    Price = 75.00m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 8,
                    Price = 100.00m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 9,
                    Price = 125.00m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 10,
                    Price = 150.00m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 11,
                    Price = 200.00m
                }
            );

        }

        public DbSet<Product>? Products { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
    }
}
