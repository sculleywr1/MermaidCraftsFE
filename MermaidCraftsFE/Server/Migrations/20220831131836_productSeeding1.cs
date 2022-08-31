using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MermaidCraftsFE.Server.Migrations
{
    public partial class productSeeding1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "A teddy bear made with baby soft yarn, perfect for your child", "https://images.squarespace-cdn.com/content/v1/5e12aa9f8c03f756cbec18fc/1607712216490-NN3SB29TDH8A2RP24HLY/classic-crochet-teddy-bear.jpg?format=1000w", 50.00m, "Teddy Bear" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "A shirt made with baby soft yarn in sizes from 2t-5t", "https://i.ytimg.com/vi/HohJhrZFr74/maxresdefault.jpg", 45.00m, "Baby Shirt" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "A small blanket made with baby soft yarn, perfect for decorating baby's nursery. (disclaimer, do not use with children below 6 months. Please use safe sleep practices!)", "https://www.anniedesigncrochet.com/wp-content/uploads/2020/04/lace-shell-crochet-baby-blanket-9.jpg", 65.00m, "Baby Blanket" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
