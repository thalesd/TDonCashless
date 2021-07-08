using System;

namespace TDonCashless.Microservices.CreateCustomerCard.Domain.Models
{
    public class CustomerCardLog
    {
        public int CustomerCardLogId {get; set;}
        public int CustomerCardId { get; set; }
        public int CustomerId { get; set; }
        public long CardNumber { get; set; }
        public int CVV { get; set; }
        public DateTime RegistrationDate { get; set; }
        public long Token { get; set; }
        public DateTime Timestamp { get; } = DateTime.Now.ToUniversalTime();
    }
}