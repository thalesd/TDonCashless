using System;
using System.Collections.Generic;
using TDonCashless.Domain.Core.Bus;
using TDonCashless.Microservices.CreateCustomerCard.Application.DTOs;
using TDonCashless.Microservices.CreateCustomerCard.Application.Interfaces;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Commands;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Interfaces;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Models;

namespace TDonCashless.Microservices.CreateCustomerCard.Application.Services
{
    public class CustomerCardService : ICustomerCardService
    {
        private readonly ICustomerCardRepository _customerCardRepository;
        private readonly IEventBus _bus;

        public CustomerCardService(ICustomerCardRepository customerCardRepository, IEventBus bus)
        {
            _customerCardRepository = customerCardRepository;
            _bus = bus;
        }

        public void CreateCustomerCard(CustomerCardCreationDTO customerCardCreation)
        {
            var initiateCreateCardCommand = new InitiateCreateCardCommand(customerCardCreation.CustomerId, customerCardCreation.CardNumber, customerCardCreation.CVV);

            _bus.SendCommand(initiateCreateCardCommand);
        }

        public IEnumerable<CustomerCard> GetCustomerCards()
        {
            return _customerCardRepository.GetCustomerCards();
        }
    }
}