﻿// <auto-generated />
using MermaidCraftsFE.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MermaidCraftsFE.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220831162957_CategorySeeding")]
    partial class CategorySeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

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
                            Price = 50.00m,
                            Title = "Teddy Bear"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "A shirt made with baby soft yarn in sizes from 2t-5t",
                            ImageUrl = "https://i.ytimg.com/vi/HohJhrZFr74/maxresdefault.jpg",
                            Price = 45.00m,
                            Title = "Baby Shirt"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "A small blanket made with baby soft yarn, perfect for decorating baby's nursery. (disclaimer, do not use with children below 6 months. Please use safe sleep practices!)",
                            ImageUrl = "https://www.anniedesigncrochet.com/wp-content/uploads/2020/04/lace-shell-crochet-baby-blanket-9.jpg",
                            Price = 65.00m,
                            Title = "Baby Blanket"
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
#pragma warning restore 612, 618
        }
    }
}
