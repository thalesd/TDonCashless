namespace TdonCashless.Microservices.Gateway.API.DTOs
{
    public class RevalidateCustomerCardTokenDTO
    {
        public int CustomerId {get; set;}
        public int CustomerCardId {get; set;}
        public int CVV {get; set;}
        public long Token {get; set;}

    }
}