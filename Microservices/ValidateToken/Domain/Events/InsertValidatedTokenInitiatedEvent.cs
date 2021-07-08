using System;
using TDonCashless.Domain.Core.Events;

namespace TDonCashless.Microservices.ValidateToken.Domain.Events
{
    public class InsertValidatedTokenInitiatedEvent : Event
    {
        public int CustomerId { get; protected set; }
        public int CustomerCardId { get; protected set; }
        public long Token { get; protected set; }
        public int CVV { get; protected set; }
        public DateTime TokenCreationDate { get; protected set; }
        public bool Validated { get; protected set; }


        public InsertValidatedTokenInitiatedEvent(int customerId, int customerCardId, long token, int cvv, bool validated)
        {
            this.CustomerId = customerId;
            this.CustomerCardId = customerCardId;
            this.Token = token;
            this.CVV = cvv;
            this.Validated = validated;
        }
    }
}