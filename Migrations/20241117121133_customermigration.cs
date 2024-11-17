﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ecom.Migrations
{
    public partial class customermigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_customer",
                columns: table => new
                {
                    Customer_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_customer", x => x.Customer_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_customer");
        }
    }
}