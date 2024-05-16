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
                ImageUrl = "https://mango364.blob.core.windows.net/product/11.jpg?sp=r&st=2024-05-16T10:41:58Z&se=2024-05-16T18:41:58Z&sv=2022-11-02&sr=b&sig=alAlrFymwlrgiQM15N1NOVfObKMfB%2FG4chxHi%2BrvJuc%3D",
                Category = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Paneer Tikka",
                Price = 13.99,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://mango364.blob.core.windows.net/product/12.jpg?sp=r&st=2024-05-16T10:42:23Z&se=2024-05-16T18:42:23Z&sv=2022-11-02&sr=b&sig=oZXSbiovX9I%2BQU3qYDqYUrhAu4QCUrCKenTxCRXc4GA%3D",
                Category = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Sweet Pie",
                Price = 10.99,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://mango364.blob.core.windows.net/product/13.jpg?sp=r&st=2024-05-16T10:42:53Z&se=2024-05-16T18:42:53Z&sv=2022-11-02&sr=b&sig=6pUwPNLLwMbnhtLWwzR8xe152gBVwImFHAAsa5rOKUs%3D",
                Category = "Dessert"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Pav Bhaji",
                Price = 15,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://mango364.blob.core.windows.net/product/14.jpg?sp=r&st=2024-05-16T10:43:20Z&se=2024-05-16T18:43:20Z&sv=2022-11-02&sr=b&sig=wjXVVpuZZrvx2MpiPt4%2F43Ul%2FcCRKTRo7cCvOqT7ccE%3D",
                Category = "Entree"
            });
        }
    }
}
