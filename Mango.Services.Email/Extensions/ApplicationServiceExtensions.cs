using Mango.Services.Email.Data;
using Mango.Services.Email.Messaging;
using Mango.Services.Email.Repository;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.Email.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            services.AddSingleton(new EmailRepository(optionBuilder.Options));

            services.AddSingleton<IAzureServiceBusConsumer, AzureServiceBusConsumer>();
            services.AddScoped<IEmailRepository, EmailRepository>();

            return services;
        }
    }
}
