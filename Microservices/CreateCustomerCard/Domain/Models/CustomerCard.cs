using System;

namespace TDonCashless.Microservices.CreateCustomerCard.Domain.Models
{
    public class CustomerCard
    {
        public int CustomerCardId {get; set;}
        public int CustomerId {get; set;}
        public long CardNumber {get; set;}
        public int CVV {get; set;}
        public DateTime RegistrationDate {get; set;}
        public long Token {get; set;}
    }
}