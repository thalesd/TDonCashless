namespace TDonCashless.Microservices.ValidateToken.Domain.Commands
{
    public class InitiateValidateTokenCommand : ValidateTokenCommand
    {
        public InitiateValidateTokenCommand(int customerId, int customerCardId, long token, int cvv)
        {
            this.CustomerId = customerId;
            this.CustomerCardId = customerCardId;
            this.Token = token;
            this.CVV = cvv;
        }
    }
}