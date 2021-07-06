using System.Collections.Generic;
using TDonCashless.Microservices.CreateCustomerCard.Application.DTOs;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Models;

namespace TDonCashless.Microservices.CreateCustomerCard.Application.Interfaces
{
    public interface ICustomerCardService
    {
        IEnumerable<CustomerCard> GetCustomerCards();

        void CreateCustomerCard(CustomerCardCreationDTO customerCardCreation);
    }
}