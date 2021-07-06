using System;

namespace Domain.Models
{
    public class CustomerCard
    {
        public int CardId {get; set;}
        public int CustomerId {get; set;}
        public long CardNumber {get; set;}
        public int CVV {get; set;}
        public DateTime RegistrationDate {get; set;}
        public long Token {get; set;}
    }
}