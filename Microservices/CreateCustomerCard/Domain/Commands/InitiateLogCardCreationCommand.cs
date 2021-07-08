using System;

namespace TDonCashless.Microservices.CreateCustomerCard.Domain.Commands
{
    public class InitiateLogCardCreationCommand : LogCardCreationCommand
    {
        public InitiateLogCardCreationCommand(int customerId, long cardNumber, int cvv, DateTime registrationDate, long token){
            this.CustomerId = customerId;
            this.CardNumber = cardNumber;
            this.CVV = cvv;
            this.RegistrationDate = registrationDate;
            this.Token = token;
        }
    }
}