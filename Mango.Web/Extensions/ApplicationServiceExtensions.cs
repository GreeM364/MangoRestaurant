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
            services.AddHttpClient<ICouponService, CouponService>();

            SD.ServerAPIBase = configuration["ServiceUrls:ServerAPI"]!;

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<ICouponService, CouponService>();
            services.AddControllersWithViews();

            return services;
        }
    }
}
