using System.Collections.Generic;
using TDonCashless.Microservices.ValidateToken.Data.Context;
using TDonCashless.Microservices.ValidateToken.Domain.Interfaces;
using TDonCashless.Microservices.ValidateToken.Domain.Models;

namespace Data.Repository
{
    public class ValidatedTokenRepository : IValidatedTokenRepository
    {
        private ValidatedTokenDbContext _ctx;

        public ValidatedTokenRepository(ValidatedTokenDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<ValidatedToken> GetValidatedTokens()
        {
            return _ctx.ValidatedTokens;
        }

        public ValidatedToken InsertNewValidatedToken(ValidatedToken newValidationAttempt)
        {
            _ctx.ValidatedTokens.Add(newValidationAttempt);

            _ctx.SaveChanges();

            return newValidationAttempt;
        }
    }
}