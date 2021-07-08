namespace TDonCashless.Microservices.CreateCustomerCard.Application.DTOs
{
    public class RevalidateCustomerCardTokenDTO
    {
        public long Token {get; set;}
        public long CardNumber {get; set;}
        public int CVV {get; set;}
    }
}