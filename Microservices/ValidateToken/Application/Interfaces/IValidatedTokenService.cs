using System.Collections.Generic;
using TDonCashless.Microservices.ValidateToken.Application.DTOs;
using TDonCashless.Microservices.ValidateToken.Domain.Models;

namespace TDonCashless.Microservices.ValidateToken.Application.Interfaces
{
    public interface IValidatedTokenService
    {
        IEnumerable<ValidatedToken> GetValidatedTokenHistory();
        void InsertValidatedToken(InsertValidatedTokenDTO validateToken);
    }
}