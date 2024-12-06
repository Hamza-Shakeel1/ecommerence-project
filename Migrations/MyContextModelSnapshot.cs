﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ecom.Models;

#nullable disable

namespace ecom.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("ecom.Models.Customer", b =>
                {
                    b.Property<int>("Customer_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Customer_Id"), 1L, 1);

                    b.Property<string>("Customer_Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Customer_Id");

                    b.ToTable("tbl_customer");
                });

            modelBuilder.Entity("ecom.Models.Faq", b =>
                {
                    b.Property<int>("Faq_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Faq_Id"), 1L, 1);

                    b.Property<string>("Faq_Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("faq_Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Faq_Id");

                    b.ToTable("tbl_faq");
                });

            modelBuilder.Entity("ecom.Models.Feeddback", b =>
                {
                    b.Property<int>("Feedback_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Feedback_Id"), 1L, 1);

                    b.Property<int>("User_Message")
                        .HasColumnType("int");

                    b.Property<int>("User_Name")
                        .HasColumnType("int");

                    b.HasKey("Feedback_Id");

                    b.ToTable("tbl_feedback");
                });

            modelBuilder.Entity("ecom.Models.Product", b =>
                {
                    b.Property<int>("Product_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Product_Id"), 1L, 1);

                    b.Property<int>("Cart_Id")
                        .HasColumnType("int");

                    b.Property<string>("Product_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Product_Id");

                    b.HasIndex("Cart_Id");

                    b.ToTable("tbl_products");
                });

            modelBuilder.Entity("ecom.Models.Product", b =>
                {
                    b.HasOne("ecom.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("Cart_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ecom.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
