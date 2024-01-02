using System.Text;
using Azure.Messaging.ServiceBus;
using Mango.Services.Email.Messages;
using Mango.Services.Email.Repository;
using Newtonsoft.Json;

namespace Mango.Services.Email.Messaging
{
    public class AzureServiceBusConsumer : IAzureServiceBusConsumer
    {
        private readonly EmailRepository _emailRepository;

        private readonly string _serviceBusConnectionString;
        private readonly string _subscriptionEmail;
        private readonly string _orderUpdatePaymentResultTopic;

        private ServiceBusProcessor orderUpdatePaymentStatusProcessor;

        public AzureServiceBusConsumer(EmailRepository emailRepository, IConfiguration configuration)
        {
            _emailRepository = emailRepository;

            _serviceBusConnectionString = configuration.GetValue<string>("ServiceBusConnectionString")!;
            _subscriptionEmail = configuration.GetValue<string>("SubscriptionName")!;
            _orderUpdatePaymentResultTopic = configuration.GetValue<string>("OrderUpdatePaymentResultTopic")!;


            var client = new ServiceBusClient(_serviceBusConnectionString);
            orderUpdatePaymentStatusProcessor = client.CreateProcessor(_orderUpdatePaymentResultTopic, _subscriptionEmail);
        }

        public async Task Start()
        {

            orderUpdatePaymentStatusProcessor.ProcessMessageAsync += OnOrderPaymentUpdateReceived;
            orderUpdatePaymentStatusProcessor.ProcessErrorAsync += ErrorHandler;
            await orderUpdatePaymentStatusProcessor.StartProcessingAsync();
        }

        public async Task Stop()
        {

            await orderUpdatePaymentStatusProcessor.StopProcessingAsync();
            await orderUpdatePaymentStatusProcessor.DisposeAsync();
        }

        Task ErrorHandler(ProcessErrorEventArgs args)
        {
            Console.WriteLine(args.Exception.ToString());
            return Task.CompletedTask;
        }

        private async Task OnOrderPaymentUpdateReceived(ProcessMessageEventArgs args)
        {
            var message = args.Message;
            var body = Encoding.UTF8.GetString(message.Body);

            UpdatePaymentResultMessage objMessage = JsonConvert.DeserializeObject<UpdatePaymentResultMessage>(body);

            await _emailRepository.SendAndLogEmail(objMessage);
            await args.CompleteMessageAsync(args.Message);
        }
    }
}
