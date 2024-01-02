namespace Mango.Services.PaymentAPI.Messages
{
    public class PaymentRequestMessage
    {
        public Guid Id { get; set; }
        public int OrderId { get; set; }
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public string CVV { get; set; }
        public string ExpiryMonthYear { get; set; }
        public double OrderTotal { get; set; }
        public string Email { get; set; }
        public DateTime MessageCreated { get; set; }
    }
}
