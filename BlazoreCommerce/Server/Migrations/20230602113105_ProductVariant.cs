using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazoreCommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductVariant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => new { x.ProductId, x.ProductTypeId });
                    table.ForeignKey(
                        name: "FK_ProductVariants_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Размер рокли", "38" },
                    { 2, "Размер рокли", "40" },
                    { 3, "Размер рокли", "42" },
                    { 4, "Размер рокли", "44" },
                    { 5, "Размер IT", "O" },
                    { 6, "Размер IT", "I" },
                    { 7, "Размер IT", "III" },
                    { 8, "Размер IT", "IV" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Url",
                value: "https://allinone.bg/uploads/product-image/image/380x608/LWO0222BK12_AW22_getthelook_model_3.jpg");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Price", "Title", "Url" },
                values: new object[] { 5, 2, "\r\nPATRIZIA PEPE\r\nБлуза\r\n202,00 лв.289,00 лв. 30 \r\nИзберете размер:\r\nКой размер съм?\r\nДОБАВИ В КОЛИЧКАТА\r\nАрт. №: OC-Pepe-1C1342-AD08-CA08\r\n\r\nПолиестер: 100%\r\nGeorgette crêpe\r\nСвободна кройка\r\nДълги ръкави\r\nДетайл Муха\r\nМоделът е висок 1,76 см и носи размер IT 40/S/0", 400m, "PATRIZIA PEPE блуза", "https://allinone.bg/uploads/product-image/image/original/1C1342_AD08_CA08_1.jpg" });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId" },
                values: new object[,]
                {
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductTypeId",
                table: "ProductVariants",
                column: "ProductTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Url",
                value: "hhttps://allinone.bg/uploads/product-image/image/380x608/LWO0222BK12_AW22_getthelook_model_3.jpg");
        }
    }
}
