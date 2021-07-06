namespace TDonCashless.Microservices.CreateCustomerCard.Domain.Commands
{
    public class InitiateCreateCardCommand : CreateCardCommand
    {
        public InitiateCreateCardCommand(int customerId, long cardNumber, int cvv){
            this.CustomerId = customerId;
            this.CardNumber = cardNumber;
            this.CVV = cvv;
        }
    }
}