using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhoneStore.Api.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddProductItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");
        }
    }
}
