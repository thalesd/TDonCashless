namespace TDonCashless.Microservices.CreateCustomerCard.Application.DTOs
{
    public class CustomerCardCreationDTO
    {
        public int CustomerId {get;}
        public long CardNumber {get;}
        public int CVV {get;}
    }
}