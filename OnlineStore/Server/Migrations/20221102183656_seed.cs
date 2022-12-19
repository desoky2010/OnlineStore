using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineStore.Server.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImgURL", "Price", "Title" },
                values: new object[] { 1, "Amazon Basics Stainless Steel Portable Fast, Electric Hot Water Kettle for Tea and Coffee - 1 Liter, Gray/Black", "https://m.media-amazon.com/images/I/91oiSVwU7OL._AC_SL1500_.jpg", 45.0, "Electric Hot Water Kettle" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImgURL", "Price", "Title" },
                values: new object[] { 2, "FAVIA Electric Kettle Water Boiler for Boiling Hot Water 1.7L with Wide Opening Auto Shut-Off & Boil-Dry Protection Tea Kettle Glass Pot Cordless LED Indicator 1500W BPA Free", "https://m.media-amazon.com/images/I/710DlgQWe-L._AC_SL1500_.jpg", 90.0, "FAVIA Electric Kettle Water" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImgURL", "Price", "Title" },
                values: new object[] { 3, "Electric Tea Kettle, Retro Electric Hot Water Kettle, 1350w Quick Boil, Thermometer Dial, Auto Shut-Off and Boil-Dry Protection, Portable Instant Heater for Making Tea, Coffee\r\n", "https://m.media-amazon.com/images/I/61qQ5LmhDdL._AC_SL1500_.jpg", 70.989999999999995, "Electric Tea Kettle" });
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
