using TDonCashless.Microservices.ValidateToken.Application.DTOs;

namespace TDonCashless.Microservices.ValidateToken.Application.Interfaces
{
    public interface IValidateTokenService
    {
        ValidatedTokenDTO ValidateToken(ValidateTokenDTO validateToken);
    }
}