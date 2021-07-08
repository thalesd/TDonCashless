namespace TDonCashless.Microservices.ValidateToken.Domain.Commands
{
    public class InitiateInsertValidatedTokenCommand : InsertValidatedTokenCommand
    {
        public InitiateInsertValidatedTokenCommand(int customerId, int customerCardId, long token, int cvv)
        {
            this.CustomerId = customerId;
            this.CustomerCardId = customerCardId;
            this.Token = token;
            this.CVV = cvv;
        }
    }
}