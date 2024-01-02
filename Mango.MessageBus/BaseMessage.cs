namespace Mango.MessageBus
{
    public class BaseMessage
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime MessageCreated { get; set; }
    }
}
