using System.Collections.Generic;
using System.Threading.Tasks;
using TDonCashless.Microservices.ValidateToken.Application.DTOs;
using TDonCashless.Microservices.ValidateToken.Domain.Models;

namespace TDonCashless.Microservices.ValidateToken.Application.Interfaces
{
    public interface IValidatedTokenService
    {
        IEnumerable<ValidatedToken> GetValidatedTokenHistory();
        Task InsertValidatedToken(InsertValidatedTokenDTO validateToken);
    }
}