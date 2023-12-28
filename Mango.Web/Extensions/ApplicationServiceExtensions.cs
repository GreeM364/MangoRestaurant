using Mango.Web.Services.IServices;
using Mango.Web.Services;

namespace Mango.Web.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient<IProductService, ProductService>();
            services.AddHttpClient<ICartService, CartService>();
            SD.ProductAPIBase = configuration["ServiceUrls:ProductAPI"]!;
            SD.ShoppingCartAPIBase = configuration["ServiceUrls:ShoppingCartAPI"]!;

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICartService, CartService>();
            services.AddControllersWithViews();

            return services;
        }
    }
}
