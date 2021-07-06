using System.Collections.Generic;
using Application.Interfaces;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services
{
    public class CustomerCardService : ICustomerCardService
    {
        private readonly ICustomerCardRepository _customerCardRepository;
        public CustomerCardService(ICustomerCardRepository customerCardRepository)
        {
            _customerCardRepository = customerCardRepository;
        }

        public IEnumerable<CustomerCard> GetCustomerCards()
        {
            return _customerCardRepository.GetCustomerCards();
        }
    }
}