using System.Collections.Generic;
using System.Threading.Tasks;
using TDonCashless.Microservices.CreateCustomerCard.Application.DTOs;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Models;

namespace TDonCashless.Microservices.CreateCustomerCard.Application.Interfaces
{
    public interface ICustomerCardService
    {
        IEnumerable<CustomerCard> GetCustomerCards();

        CustomerCard CreateCustomerCard(CustomerCardCreationDTO customerCardCreation);

        CustomerCard GetCustomerCardById(int customerCardId);

        Task<bool> RevalidateCustomerCardToken(RevalidateCustomerCardTokenDTO revalidateCustomerCard);
    }
}