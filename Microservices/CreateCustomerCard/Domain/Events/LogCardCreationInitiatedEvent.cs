using System;
using TDonCashless.Domain.Core.Events;

namespace TDonCashless.Microservices.CreateCustomerCard.Domain.Events
{
    public class LogCardCreationInitiatedEvent : Event
    {
        public int CustomerId { get; private set; }
        public long CardNumber { get; private set; }
        public int CVV { get; private set; }
        public DateTime RegistrationDate {get; private set;}
        public long Token {get; private set;}

        public LogCardCreationInitiatedEvent(int customerId, long cardNumber, int cvv, DateTime registrationDate, long token)
        {
            this.CustomerId = customerId;
            this.CardNumber = cardNumber;
            this.CVV = cvv;
            this.RegistrationDate = registrationDate;
            this.Token = token;
        }
    }
}