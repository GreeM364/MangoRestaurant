using Mango.MessageBus;
using Mango.Services.PaymentAPI.Messaging;
using Microsoft.OpenApi.Models;
using PaymentProcessor;

namespace Mango.Services.PaymentAPI.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IProcessPayment, ProcessPayment>();
            services.AddSingleton<IAzureServiceBusConsumer, AzureServiceBusConsumer>();
            services.AddSingleton<IMessageBus, AzureServiceBusMessageBus>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Mango.Services.PaymentAPI", Version = "v1" });
            });

            return services;
        }
    }
}
