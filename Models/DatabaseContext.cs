using Azure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace QuoteGeneratorThree.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductQuote> QuoteProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Product>()
            //.HasMany(e => e.Quotes)
            //.WithMany(e => e.Products)
            // .UsingEntity(
            // "ProductQuote",
            // l => l.HasOne(typeof(Quote)).WithMany().HasForeignKey("QuoteId").HasPrincipalKey(nameof(Quote.Id)),
            // r => r.HasOne(typeof(Product)).WithMany().HasForeignKey("ProductId").HasPrincipalKey(nameof(Product.Id)),
            // j => j.HasKey("ProductId", "QuoteId"));

            modelBuilder.Entity<ProductQuote>()
                .HasKey(x => new { x.ProductId, x.QuoteId });

        }

    }
}
