using Mango.MessageBus;
using Mango.Services.PaymentAPI.Messaging;
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

            return services;
        }
    }
}
