using System;
using System.Threading.Tasks;
using TDonCashless.Domain.Core.Events;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Events;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Interfaces;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Models;

namespace TDonCashless.Microservices.CreateCustomerCard.Domain.EventHandlers
{
    public class LogCardCreationInitiatedEventHandler : IEventHandler<LogCardCreationInitiatedEvent>
    {
        private readonly ICustomerCardRepository _customerCardRepository;
        public LogCardCreationInitiatedEventHandler(ICustomerCardRepository customerCardRepository){
            _customerCardRepository = customerCardRepository;
        }
        public Task HandleAsync(LogCardCreationInitiatedEvent @event)
        {
            _customerCardRepository.InsertNewLogCustomerCardCreation(new CustomerCard(){
                CardNumber = @event.CardNumber,
                CustomerId = @event.CustomerId,
                CVV = @event.CVV,
                RegistrationDate = DateTime.Now,
                Token = _customerCardRepository.CreateCardToken(@event.CardNumber, @event.CVV)
            });

            return Task.CompletedTask;
        }
    }
}