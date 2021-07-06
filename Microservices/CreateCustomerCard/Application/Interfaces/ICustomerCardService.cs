using System.Collections.Generic;
using Domain.Models;

namespace Application.Interfaces
{
    public interface ICustomerCardService
    {
        IEnumerable<CustomerCard> GetCustomerCards();
    }
}