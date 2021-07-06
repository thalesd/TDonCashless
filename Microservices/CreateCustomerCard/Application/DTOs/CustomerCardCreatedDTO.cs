using TDonCashless.Microservices.CreateCustomerCard.Domain.Models;

namespace TDonCashless.Microservices.CreateCustomerCard.Application.DTOs
{
    public class CustomerCardCreatedDTO
    {
        public CustomerCardCreatedDTO(CustomerCard newCard){
            this.CustomerId = newCard.CustomerId;
            this.CustomerCardId = newCard.CustomerCardId;
            this.CVV = newCard.CVV;
            this.Token = newCard.Token;
        }

        public int CustomerId {get; set;}
        public int CustomerCardId {get; set;}
        public long Token {get; set;}
        public int CVV {get; set;}
    }
}