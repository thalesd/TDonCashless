using System.Threading.Tasks;
using TDonCashless.Domain.Core.Events;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Events;

namespace TDonCashless.Microservices.CreateCustomerCard.Domain.EventHandlers
{
    public class CreateCardEventHandler : IEventHandler<CreateCardInitiatedEvent>
    {
        public Task HandleAsync(CreateCardInitiatedEvent @event)
        {
            return Task.CompletedTask;
        }
    }
}