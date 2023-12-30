using Mango.Services.OrderAPI.Data;
using Mango.Services.OrderAPI.Repository;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.OrderAPI.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            services.AddSingleton(new OrderRepository(optionBuilder.Options));

            return services;
        }
    }
}
