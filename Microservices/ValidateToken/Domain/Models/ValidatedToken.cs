using System;

namespace TDonCashless.Microservices.ValidateToken.Domain.Models
{
    public class ValidatedToken
    {
        public int ValidatedTokenId {get; set;}
        public int CustomerId {get; set;}
        public int CardId {get; set;}
        public bool Valid {get; set;}
        public DateTime ValidatedTime {get; set;}
    }
}