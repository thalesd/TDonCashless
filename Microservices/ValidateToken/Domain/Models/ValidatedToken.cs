using System;

namespace TDonCashless.Microservices.ValidateToken.Domain.Models
{
    public class ValidatedToken
    {
        public int ValidatedTokenId {get; set;}
        public int CustomerId {get; set;}
        public int CardId {get; set;}
        public long Token {get; set;}
        public int CVV {get; set;}
        public DateTime TokenCreationDate {get; set;}
        public bool Valid {get; set;}
        public DateTime ValidatedLogTime {get; set;}
    }
}