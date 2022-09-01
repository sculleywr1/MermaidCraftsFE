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
                    Price = 50.00m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "Baby Shirt",
                    Description = "A shirt made with baby soft yarn in sizes from 2t-5t",
                    ImageUrl = "https://i.ytimg.com/vi/HohJhrZFr74/maxresdefault.jpg",
                    Price = 45.00m,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 3,
                    Title = "Baby Blanket",
                    Description = "A small blanket made with baby soft yarn, perfect for decorating baby's nursery. (disclaimer, do not use with children below 6 months. Please use safe sleep practices!)",
                    ImageUrl = "https://www.anniedesigncrochet.com/wp-content/uploads/2020/04/lace-shell-crochet-baby-blanket-9.jpg",
                    Price = 65.00m,
                    CategoryId = 3
                }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
