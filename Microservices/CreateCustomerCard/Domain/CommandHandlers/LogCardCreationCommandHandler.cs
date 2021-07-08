using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TDonCashless.Domain.Core.Bus;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Commands;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Events;

namespace TDonCashless.Microservices.CreateCustomerCard.Domain.CommandHandlers
{
    public class LogCardCreationCommandHandler : IRequestHandler<LogCardCreationCommand, bool>
    {
        private readonly IEventBus _bus;

        public LogCardCreationCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }

        public Task<bool> Handle(LogCardCreationCommand request, CancellationToken cancellationToken)
        {
            //publish event to RabbitMQ
            _bus.Publish(new LogCardCreationInitiatedEvent(request.CustomerId, request.CardNumber, request.CVV, request.RegistrationDate, request.Token));

            return Task.FromResult(true);
        }
    }
}