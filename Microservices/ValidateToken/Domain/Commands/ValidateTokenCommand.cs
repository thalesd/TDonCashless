namespace Domain.Commands
{
    public class ValidateTokenCommand
    {
        public int CustomerId { get; protected set; }
        public int CustomerCardId { get; protected set; }
        public long Token { get; protected set; }
        public int CVV { get; protected set; }
    }
}