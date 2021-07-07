using System.Threading.Tasks;
using TDonCashless.Domain.Core.Events;
using TDonCashless.Microservices.ValidateToken.Domain.Events;

namespace TDonCashless.Microservices.ValidateToken.Domain.EventHandlers
{
    public class ValidateTokenEventHandler : IEventHandler<ValidateTokenInitiatedEvent>
    {
        public ValidateTokenEventHandler()
        {

        }

        public Task HandleAsync(ValidateTokenInitiatedEvent @event)
        {
            return Task.CompletedTask;
        }
    }
}