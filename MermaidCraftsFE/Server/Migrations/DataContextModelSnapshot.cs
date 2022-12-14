// <auto-generated />
using System;
using MermaidCraftsFE.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MermaidCraftsFE.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MermaidCraftsFE.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Toys",
                            Url = "Toys"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Clothes",
                            Url = "clothes"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Blankets",
                            Url = "blankets"
                        });
                });

            modelBuilder.Entity("MermaidCraftsFE.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "A teddy bear made with baby soft yarn, perfect for your child",
                            ImageUrl = "https://images.squarespace-cdn.com/content/v1/5e12aa9f8c03f756cbec18fc/1607712216490-NN3SB29TDH8A2RP24HLY/classic-crochet-teddy-bear.jpg?format=1000w",
                            Title = "Teddy Bear"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "A shirt made with baby soft yarn in sizes from 2t-5t",
                            ImageUrl = "https://i.ytimg.com/vi/HohJhrZFr74/maxresdefault.jpg",
                            Title = "Baby Shirt"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "A small blanket made with baby soft yarn, perfect for decorating baby's nursery. (disclaimer, do not use with children below 6 months. Please use safe sleep practices!)",
                            ImageUrl = "https://www.anniedesigncrochet.com/wp-content/uploads/2020/04/lace-shell-crochet-baby-blanket-9.jpg",
                            Title = "Baby Blanket"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Description = "A decorative and comfortable throw blanket made with up to three colors of your choice",
                            ImageUrl = "https://www.mamainastitch.com/wp-content/uploads/2018/10/Fall-Easy-Beginner-blanket-pattern-crochet.jpg",
                            Title = "Throw Blanket"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            Description = "A decorative and comfortable blanket for any size bed up to three colors of your choice",
                            ImageUrl = "https://undergroundcrafter.com/wp-content/uploads/2015/03/Mod-9-Patch-Blanket-5-of-9.jpg",
                            Title = "Bed Blanket"
                        });
                });

            modelBuilder.Entity("MermaidCraftsFE.Shared.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Stuffed Animal"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Doll Clothes"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Child"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Teen"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Adult"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Baby"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Twin"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Throw"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Full"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Queen"
                        },
                        new
                        {
                            Id = 11,
                            Name = "King"
                        });
                });

            modelBuilder.Entity("MermaidCraftsFE.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<decimal?>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "ProductTypeId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("ProductVariants");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 1,
                            Price = 50.00m
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 2,
                            Price = 30.00m
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 3,
                            Price = 75.00m
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 4,
                            Price = 100.00m
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 5,
                            Price = 125.00m
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 6,
                            Price = 50.00m
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 7,
                            Price = 75.00m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 8,
                            Price = 100.00m
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 9,
                            Price = 125.00m
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 10,
                            Price = 150.00m
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 11,
                            Price = 200.00m
                        });
                });

            modelBuilder.Entity("MermaidCraftsFE.Shared.Product", b =>
                {
                    b.HasOne("MermaidCraftsFE.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MermaidCraftsFE.Shared.ProductVariant", b =>
                {
                    b.HasOne("MermaidCraftsFE.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MermaidCraftsFE.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("MermaidCraftsFE.Shared.Product", b =>
                {
                    b.Navigation("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}
