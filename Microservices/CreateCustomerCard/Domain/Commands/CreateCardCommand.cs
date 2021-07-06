using TDonCashless.Domain.Core.Commands;

namespace TDonCashless.Microservices.CreateCustomerCard.Domain.Commands
{
    public abstract class CreateCardCommand : Command
    {
        public int CustomerId {get; protected set;} 
        public long CardNumber {get; protected set;}
        public int CVV {get; protected set;}
    }
}