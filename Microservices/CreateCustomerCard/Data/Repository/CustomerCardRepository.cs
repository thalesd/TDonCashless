using System.Collections.Generic;
using TDonCashless.Microservices.CreateCustomerCard.Data.Context;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Interfaces;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Models;

namespace TDonCashless.Microservices.CreateCustomerCard.Data.Repository
{
    public class CustomerCardRepository : ICustomerCardRepository
    {
        private CustomerCardDbContext _ctx;

        public CustomerCardRepository(CustomerCardDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<CustomerCard> GetCustomerCards()
        {
            return _ctx.CustomerCards;
        }
    }
}