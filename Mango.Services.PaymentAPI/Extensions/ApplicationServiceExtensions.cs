using Mango.Services.PaymentAPI.Messaging;
using Mango.Services.PaymentAPI.RabbitMQSender;
using Microsoft.OpenApi.Models;
using PaymentProcessor;

namespace Mango.Services.PaymentAPI.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddSingleton<IProcessPayment, ProcessPayment>();
            services.AddSingleton<IRabbitMQPaymentMessageSender, RabbitMQPaymentMessageSender>();
            services.AddHostedService<RabbitMQPaymentConsumer>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Mango.Services.PaymentAPI", Version = "v1" });
            });

            return services;
        }
    }
}
