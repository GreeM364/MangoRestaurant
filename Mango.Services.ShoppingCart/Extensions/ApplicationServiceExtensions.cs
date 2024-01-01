using AutoMapper;
using Mango.MessageBus;
using Mango.Services.ShoppingCartAPI.Data;
using Mango.Services.ShoppingCartAPI.Repository;
using Mango.Services.ShoppingCartAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ShoppingCartAPI.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
            services.AddSingleton(mapper);
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<ICouponRepository, CouponRepository>();
            services.AddSingleton<IMessageBus, AzureServiceBusMessageBus>();

            services.AddHttpClient<ICouponRepository, CouponRepository>(u => u.BaseAddress =
                new Uri(configuration["ServiceUrls:CouponAPI"]));

            return services;
        }
    }
}
