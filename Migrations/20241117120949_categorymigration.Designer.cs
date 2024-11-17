﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ecom.Models;

#nullable disable

namespace ecom.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20241117120949_categorymigration")]
    partial class categorymigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ecom.Models.Admin", b =>
                {
                    b.Property<int>("admin_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("admin_Id"), 1L, 1);

                    b.Property<string>("admin_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("admin_Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("admin_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("admin_Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("admin_Id");

                    b.ToTable("tbl_admin");
                });

            modelBuilder.Entity("ecom.Models.Cart", b =>
                {
                    b.Property<int>("Cart_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cart_Id"), 1L, 1);

                    b.Property<int>("Cart_Status")
                        .HasColumnType("int");

                    b.Property<int>("Cust_Id")
                        .HasColumnType("int");

                    b.Property<int>("Prod_Id")
                        .HasColumnType("int");

                    b.Property<int>("Product_Quantity")
                        .HasColumnType("int");

                    b.HasKey("Cart_Id");

                    b.ToTable("tbl_cart");
                });

            modelBuilder.Entity("ecom.Models.Category", b =>
                {
                    b.Property<int>("category_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("category_Id"), 1L, 1);

                    b.Property<string>("Category_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("category_Id");

                    b.ToTable("tbl_categories");
                });
#pragma warning restore 612, 618
        }
    }
}
