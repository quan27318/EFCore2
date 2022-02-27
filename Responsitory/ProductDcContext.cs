using Microsoft.EntityFrameworkCore;

namespace EFCore2.Models
{
    public class ProductDcContext : DbContext
    {
        public ProductDcContext() { }
        public ProductDcContext(DbContextOptions<ProductDcContext> options) : base(options) { }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     Mo
        //     optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=DBName;Integrated Security=True");
        // }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>()
            .HasOne<Category>()
            .WithMany()
            .HasForeignKey(p => p.CategoryID);

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}