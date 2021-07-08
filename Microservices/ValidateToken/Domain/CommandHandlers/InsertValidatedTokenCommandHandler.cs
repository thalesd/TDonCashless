using System.Threading;
using System.Threading.Tasks;
using TDonCashless.Microservices.ValidateToken.Domain.Commands;
using TDonCashless.Microservices.ValidateToken.Domain.Events;
using TDonCashless.Domain.Core.Bus;
using MediatR;

namespace TDonCashless.Microservices.ValidateToken.Domain.CommandHandlers
{
    public class InsertValidatedTokenCommandHandler : IRequestHandler<InsertValidatedTokenCommand, bool>
    {
        private readonly IEventBus _bus;

        public InsertValidatedTokenCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }

        public Task<bool> Handle(InsertValidatedTokenCommand request, CancellationToken cancellationToken)
        {
            //publish event to RabbitMQ
            _bus.Publish(new InsertValidatedTokenInitiatedEvent(request.CustomerId, request.CustomerCardId, request.Token, request.CVV, request.Validated));

            return Task.FromResult(true);
        }
    }
}