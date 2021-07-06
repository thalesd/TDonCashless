using System.Collections.Generic;
using TDonCashless.Microservices.ValidateToken.Domain.Models;

namespace TDonCashless.Microservices.ValidateToken.Domain.Interfaces
{
    public interface IValidatedTokenRepository
    {
        IEnumerable<ValidatedToken> GetValidatedTokens();

        ValidatedToken InsertNewValidatedToken(ValidatedToken newValidationAttempt);
    }
}