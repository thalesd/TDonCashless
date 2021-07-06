using System.Threading;
using System.Threading.Tasks;
using TDonCashless.Microservices.ValidateToken.Domain.Commands;
using TDonCashless.Microservices.ValidateToken.Domain.Events;
using TDonCashless.Domain.Core.Bus;
using MediatR;

namespace TDonCashless.Microservices.ValidateToken.Domain.CommandHandlers
{
    public class ValidateTokenCommandHandler : IRequestHandler<ValidateTokenCommand, bool>
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