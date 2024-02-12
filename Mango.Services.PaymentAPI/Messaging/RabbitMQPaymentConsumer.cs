using System.Text;
using Mango.Services.PaymentAPI.Messages;
using Mango.Services.PaymentAPI.RabbitMQSender;
using Newtonsoft.Json;
using PaymentProcessor;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Mango.Services.PaymentAPI.Messaging
{
    public class RabbitMQPaymentConsumer : BackgroundService
    {
        private readonly IRabbitMQPaymentMessageSender _rabbitmqSender;
        private readonly IProcessPayment _processPayment;
        private readonly string _checkoutMessageQueue;
        private IConnection _connection;
        private IModel _channel;

        public RabbitMQPaymentConsumer(IConfiguration configuration, IRabbitMQPaymentMessageSender rabbitmqSender, IProcessPayment processPayment)
        {
            _rabbitmqSender = rabbitmqSender;
            _processPayment = processPayment;
            _checkoutMessageQueue = configuration["CheckoutMessageQueue"]!;

            var factory = new ConnectionFactory
            {
                HostName =  configuration["RabbitMQ:Hostname"]!,
                UserName = configuration["RabbitMQ:Username"]!,
                Password = configuration["RabbitMQ:Password"]!
            };

            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();

            _channel.QueueDeclare(queue: _checkoutMessageQueue, false, false, false, arguments: null);
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            stoppingToken.ThrowIfCancellationRequested();

            var consumer = new EventingBasicConsumer(_channel);
            consumer.Received += (ch, e) =>
            {
                var content = Encoding.UTF8.GetString(e.Body.ToArray());
                PaymentRequestMessage paymentRequestMessage = JsonConvert.DeserializeObject<PaymentRequestMessage>(content);
                HandleMessage(paymentRequestMessage).GetAwaiter().GetResult();

                _channel.BasicAck(e.DeliveryTag, false);
            };

            _channel.BasicConsume(_checkoutMessageQueue, false, consumer);

            return Task.CompletedTask;
        }

        private async Task HandleMessage(PaymentRequestMessage paymentRequestMessage)
        {
            var result = _processPayment.PaymentProcessor();

            UpdatePaymentResultMessage updatePaymentResultMessage = new UpdatePaymentResultMessage()
            {
                Status = result,
                OrderId = paymentRequestMessage.OrderId,
                Email = paymentRequestMessage.Email,
                MessageCreated = DateTime.Now
            };

            _rabbitmqSender.SendMessage(updatePaymentResultMessage);
        }
    }
}
