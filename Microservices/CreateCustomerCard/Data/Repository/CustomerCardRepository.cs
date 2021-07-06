using System.Collections.Generic;
using Data.Context;
using Domain.Interfaces;
using Domain.Models;

namespace Data.Repository
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