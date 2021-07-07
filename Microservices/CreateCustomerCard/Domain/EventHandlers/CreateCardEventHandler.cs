using System;
using System.Threading.Tasks;
using TDonCashless.Domain.Core.Events;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Events;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Interfaces;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Models;

namespace TDonCashless.Microservices.CreateCustomerCard.Domain.EventHandlers
{
    public class CreateCardEventHandler : IEventHandler<CreateCardInitiatedEvent>
    {
        private readonly ICustomerCardRepository _customerCardRepository;
        public CreateCardEventHandler(ICustomerCardRepository customerCardRepository){
            _customerCardRepository = customerCardRepository;
        }
        public Task HandleAsync(CreateCardInitiatedEvent @event)
        {
            _customerCardRepository.InsertNewCustomerCard(new CustomerCard(){
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