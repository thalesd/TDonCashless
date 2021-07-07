using System.Collections.Generic;
using TDonCashless.Microservices.ValidateToken.Application.DTOs;
using TDonCashless.Microservices.ValidateToken.Domain.Models;

namespace TDonCashless.Microservices.ValidateToken.Application.Interfaces
{
    public interface IValidateTokenService
    {
        IEnumerable<ValidatedToken> GetValidatedTokenHistory();
        void ValidateToken(ValidateTokenDTO validateToken);
    }
}