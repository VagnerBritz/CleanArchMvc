using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchMvc.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixdbsetnameProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producs_Categories_CategoryId",
                table: "Producs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producs",
                table: "Producs");

            migrationBuilder.RenameTable(
                name: "Producs",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_Producs_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Producs");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Producs",
                newName: "IX_Producs_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producs",
                table: "Producs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Producs_Categories_CategoryId",
                table: "Producs",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
