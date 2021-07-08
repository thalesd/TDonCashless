namespace TdonCashless.Microservices.Gateway.API.DTOs
{
    public class CreateCardDTO
    {
        public int CustomerId {get; set;}
        public long CardNumber {get; set;}
        public int CVV {get; set;}
    }
}