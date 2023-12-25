using Mango.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Samosa",
                Price = 15,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://mango364.blob.core.windows.net/product/11.jpg?sv=2022-11-02&ss=b&srt=o&sp=r&se=2024-01-31T04:19:09Z&st=2023-12-25T20:19:09Z&spr=https&sig=Ru9gUDGKisZTdtJ2SEx6CKoWZn92%2F3A%2BQrIH%2FwMr58E%3D",
                Category = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Paneer Tikka",
                Price = 13.99,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://mango364.blob.core.windows.net/product/12.jpg?sv=2022-11-02&ss=b&srt=o&sp=r&se=2024-01-31T04:19:09Z&st=2023-12-25T20:19:09Z&spr=https&sig=Ru9gUDGKisZTdtJ2SEx6CKoWZn92%2F3A%2BQrIH%2FwMr58E%3D",
                Category = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Sweet Pie",
                Price = 10.99,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://mango364.blob.core.windows.net/product/13.jpg?sv=2022-11-02&ss=b&srt=o&sp=r&se=2024-01-31T04:19:09Z&st=2023-12-25T20:19:09Z&spr=https&sig=Ru9gUDGKisZTdtJ2SEx6CKoWZn92%2F3A%2BQrIH%2FwMr58E%3D",
                Category = "Dessert"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Pav Bhaji",
                Price = 15,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://mango364.blob.core.windows.net/product/14.jpg?sv=2022-11-02&ss=b&srt=o&sp=r&se=2024-01-31T04:19:09Z&st=2023-12-25T20:19:09Z&spr=https&sig=Ru9gUDGKisZTdtJ2SEx6CKoWZn92%2F3A%2BQrIH%2FwMr58E%3D",
                Category = "Entree"
            });
        }
    }
}
