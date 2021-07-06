using TDonCashless.Domain.Core.Events;

namespace TDonCashless.Microservices.CreateCustomerCard.Domain.Events
{
    public class CreateCardInitiatedEvent : Event
    {
        public int CustomerId { get; private set; }
        public long CardNumber { get; private set; }
        public int CVV { get; private set; }

        public CreateCardInitiatedEvent(int customerId, long cardNumber, int cvv)
        {
            this.CustomerId = customerId;
            this.CardNumber = cardNumber;
            this.CVV = cvv;
        }
    }
}