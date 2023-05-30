using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazoreCommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductsSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Price", "Title", "Url" },
                values: new object[,]
                {
                    { 1, "Арт. №: OC-Pepe-1C1342-A432-FE40", 329m, "PATRIZIA PEPE Блуза", "https://allinone.bg/uploads/product-image/image/380x608/1C1342_A432_FE40_1.jpg" },
                    { 2, "Арт. №: OC-Pepe-1A2238-A432-FE40", 778m, "PATRIZIA PEPE рокля", "https://allinone.bg/uploads/product-image/image/original/1A2238_A432_FE40_2.jpg" },
                    { 3, "Арт. №: OC-Pepe-2A2508-K024-J3Q8", 544m, "PATRIZIA PEPE рокля", "https://allinone.bg/uploads/product-image/image/original/2A2508_K024_J3Q8_2.jpg" }
                });
        }

        /// <inheritdoc />
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

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
