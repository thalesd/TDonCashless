using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        public CustomerCard CreateCustomerCard(CustomerCardCreationDTO customerCardCreation)
        {
            var createdCard = _customerCardRepository.InsertNewCustomerCard(new CustomerCard()
            {
                CardNumber = customerCardCreation.CardNumber,
                CustomerId = customerCardCreation.CustomerId,
                CVV = customerCardCreation.CVV,
                RegistrationDate = DateTime.Now.ToUniversalTime(),
                Token = _customerCardRepository.CreateCardToken(customerCardCreation.CardNumber, customerCardCreation.CVV)
            });

            var initiateLogCardCreationCommand = new InitiateLogCardCreationCommand(
                createdCard.CustomerId,
                createdCard.CardNumber,
                createdCard.CVV,
                createdCard.RegistrationDate,
                createdCard.Token
            );

            _bus.SendCommand(initiateLogCardCreationCommand);

            return createdCard;
        }

        public CustomerCard GetCustomerCardById(int customerCardId)
        {
            return _customerCardRepository.GetCustomerCardById(customerCardId);
        }

        public IEnumerable<CustomerCard> GetCustomerCards()
        {
            return _customerCardRepository.GetCustomerCards();
        }

        public Task<bool> RevalidateCustomerCardToken(RevalidateCustomerCardTokenDTO revalidateCustomerCard)
        {
            var customerCard = _customerCardRepository.GetCustomerCardById(revalidateCustomerCard.CustomerCardId);

            if (customerCard.RegistrationDate < DateTime.Now.ToUniversalTime().AddMinutes(-30)) return Task.FromResult(false);

            if (revalidateCustomerCard.CustomerId != customerCard.CustomerId) return Task.FromResult(false);

            Console.WriteLine(customerCard.CardNumber);

            var regeneratedToken = _customerCardRepository.CreateCardToken(customerCard.CardNumber, revalidateCustomerCard.CVV);

            return Task.FromResult(revalidateCustomerCard.Token == regeneratedToken);
        }
    }
}