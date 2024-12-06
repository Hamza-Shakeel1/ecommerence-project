using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ecom.Models
{
    public class MyContext: DbContext
    {
        public MyContext( DbContextOptions <MyContext> options): base(options) 
        {
            
        }
        public DbSet<Admin> tbl_admin { get; set; }
        public DbSet<Cart> tbl_cart { get; set; }
        public DbSet<Category> tbl_categories { get; set; }
        public DbSet<Customer> tbl_customer { get; set; }
        public DbSet<Faq> tbl_faq { get; set; }
        public DbSet<Feeddback>tbl_feedback { get; set; }
        public DbSet<Product> tbl_products { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<Product>() 
                .HasOne(p => p.Category)
                .WithMany(c=>c.Products)
                .HasForeignKey(p=>p.Cart_Id);
		}
	}
}
