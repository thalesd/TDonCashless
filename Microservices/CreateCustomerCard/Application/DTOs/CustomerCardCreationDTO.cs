using System;

namespace TDonCashless.Microservices.CreateCustomerCard.Application.DTOs
{
    public class CustomerCardCreationDTO
    {
        public int CustomerId {get; set;}
        public long CardNumber {get; set;}
        public int CVV {get; set;}
    }
}