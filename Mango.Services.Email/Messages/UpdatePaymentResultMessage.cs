namespace Mango.Services.Email.Messages
{
    public class UpdatePaymentResultMessage
    {
        public Guid Id { get; set; }
        public DateTime MessageCreated { get; set; }
        public int OrderId { get; set; }
        public bool Status { get; set; }
        public string Email { get; set; }
    }
}
