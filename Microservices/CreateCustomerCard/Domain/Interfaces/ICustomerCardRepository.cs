using System.Collections.Generic;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface ICustomerCardRepository
    {
        IEnumerable<CustomerCard> GetCustomerCards();
    }
}