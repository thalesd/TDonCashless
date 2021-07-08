using System;

namespace TdonCashless.Microservices.Gateway.API.DTOs
{
    public class CreatedCard
    {
        public int CustomerCardId {get; set;}
        public DateTime RegistrationDate {get; set;}
        public long Token {get; set;}
    }
}