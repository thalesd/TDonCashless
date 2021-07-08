namespace TDonCashless.Microservices.CreateCustomerCard.Application.DTOs
{
    public class RevalidateCustomerCardTokenDTO
    {
        public int CustomerId {get; set;}
        public int CustomerCardId {get; set;}
        public long Token {get; set;}
        public int CVV {get; set;}
    }
}