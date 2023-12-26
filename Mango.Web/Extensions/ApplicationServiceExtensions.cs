using Mango.Web.Services.IServices;
using Mango.Web.Services;

namespace Mango.Web.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient<IProductService, ProductService>();
            SD.ProductAPIBase = configuration["ServiceUrls:ProductAPI"]!;

            services.AddScoped<IProductService, ProductService>();
            services.AddControllersWithViews();

            return services;
        }
    }
}
