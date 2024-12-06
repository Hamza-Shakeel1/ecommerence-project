using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ecom.Migrations
{
    public partial class updatedproductandcategorymigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_tbl_products_Cart_Id",
                table: "tbl_products",
                column: "Cart_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_products_tbl_categories_Cart_Id",
                table: "tbl_products",
                column: "Cart_Id",
                principalTable: "tbl_categories",
                principalColumn: "category_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_products_tbl_categories_Cart_Id",
                table: "tbl_products");

            migrationBuilder.DropIndex(
                name: "IX_tbl_products_Cart_Id",
                table: "tbl_products");
        }
    }
}
