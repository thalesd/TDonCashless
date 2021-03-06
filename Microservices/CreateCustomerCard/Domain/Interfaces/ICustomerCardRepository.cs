using System.Collections.Generic;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Models;

namespace TDonCashless.Microservices.CreateCustomerCard.Domain.Interfaces
{
    public interface ICustomerCardRepository
    {
        IEnumerable<CustomerCard> GetCustomerCards();

        CustomerCard InsertNewCustomerCard(CustomerCard newCard);

        CustomerCardLog InsertNewLogCustomerCardCreation(CustomerCard newCard);

        long CreateCardToken(long cardNumber, int cvv);

        CustomerCard GetCustomerCardById(int customerCardId);
    }
}