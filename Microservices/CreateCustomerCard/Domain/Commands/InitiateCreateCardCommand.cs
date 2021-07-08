using System;

namespace TDonCashless.Microservices.CreateCustomerCard.Domain.Commands
{
    public class InitiateCreateCardCommand : CreateCardCommand
    {
        public InitiateCreateCardCommand(int customerId, long cardNumber, int cvv, DateTime registrationDate, long token){
            this.CustomerId = customerId;
            this.CardNumber = cardNumber;
            this.CVV = cvv;
            this.RegistrationDate = registrationDate;
            this.Token = token;
        }
    }
}