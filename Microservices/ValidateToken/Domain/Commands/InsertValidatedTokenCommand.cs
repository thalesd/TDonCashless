using System;
using TDonCashless.Domain.Core.Commands;

namespace TDonCashless.Microservices.ValidateToken.Domain.Commands
{
    public class InsertValidatedTokenCommand : Command
    {
        public int CustomerId { get; protected set; }
        public int CustomerCardId { get; protected set; }
        public long Token { get; protected set; }
        public int CVV { get; protected set; }
        public bool Validated { get; protected set; }
    }
}