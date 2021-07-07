using System;
using TDonCashless.Domain.Core.Events;

namespace TDonCashless.Microservices.ValidateToken.Domain.Events
{
    public class ValidateTokenInitiatedEvent : Event
    {
        public int CustomerId { get; protected set; }
        public int CustomerCardId { get; protected set; }
        public long Token { get; protected set; }
        public int CVV { get; protected set; }
        public DateTime TokenCreationDate {get; protected set;}
        

        public ValidateTokenInitiatedEvent(int customerId, int customerCardId, long token, int cvv)
        {
            this.CustomerId = customerId;
            this.CustomerCardId = customerCardId;
            this.Token = token;
            this.CVV = cvv;
        }
    }
}