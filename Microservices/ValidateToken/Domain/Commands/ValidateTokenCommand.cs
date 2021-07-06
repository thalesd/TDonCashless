using TDonCashless.Domain.Core.Commands;

namespace TDonCashless.Microservices.ValidateToken.Domain.Commands
{
    public class ValidateTokenCommand : Command
    {
        public int CustomerId { get; protected set; }
        public int CustomerCardId { get; protected set; }
        public long Token { get; protected set; }
        public int CVV { get; protected set; }
    }
}