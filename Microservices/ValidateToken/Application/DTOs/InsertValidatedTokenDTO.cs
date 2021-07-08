namespace TDonCashless.Microservices.ValidateToken.Application.DTOs
{
    public class InsertValidatedTokenDTO
    {
        public int CustomerId {get; set;}
        public int CustomerCardId {get; set;}
        public long Token {get; set;}
        public int CVV {get; set;}
    }
}