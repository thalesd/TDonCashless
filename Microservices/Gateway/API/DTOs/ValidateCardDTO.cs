namespace TdonCashless.Microservices.Gateway.API.DTOs
{
    public class ValidateCardDTO
    {
        public int CustomerId {get; set;}
        public int CustomerCardId {get; set;}
        public long Token {get; set;}
        public int CVV {get; set;}
    }
}