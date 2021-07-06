using System.Threading;
using System.Threading.Tasks;
using Domain.Commands;
using Domain.Events;
using TDonCashless.Domain.Core.Bus;

namespace Domain.CommandHandlers
{
    public class ValidateTokenCommandHandler
    {
        private readonly IEventBus _bus;

        public ValidateTokenCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }

        public Task<bool> Handle(ValidateTokenCommand request, CancellationToken cancellationToken)
        {
            //publish event to RabbitMQ
            _bus.Publish(new ValidateTokenInitiatedEvent(request.CustomerId, request.CustomerCardId, request.Token, request.CVV));

            return Task.FromResult(true);
        }
    }
}