using Microsoft.EntityFrameworkCore.Migrations;

namespace SweetShop.Migrations
{
    public partial class Seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Flavors",
                columns: new[] { "FlavorId", "FlavorName" },
                values: new object[,]
                {
                    { 1, "Sweet" },
                    { 2, "Salty" },
                    { 3, "Bitter" },
                    { 4, "Chocolatey" },
                    { 5, "Sour" },
                    { 6, "Fruity" },
                    { 7, "Umami" },
                    { 8, "Nutty" },
                    { 9, "Spicy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Flavors",
                keyColumn: "FlavorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Flavors",
                keyColumn: "FlavorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Flavors",
                keyColumn: "FlavorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Flavors",
                keyColumn: "FlavorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Flavors",
                keyColumn: "FlavorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Flavors",
                keyColumn: "FlavorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Flavors",
                keyColumn: "FlavorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Flavors",
                keyColumn: "FlavorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Flavors",
                keyColumn: "FlavorId",
                keyValue: 9);
        }
    }
}
