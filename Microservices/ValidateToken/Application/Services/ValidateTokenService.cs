using System.Collections.Generic;
using TDonCashless.Domain.Core.Bus;
using TDonCashless.Microservices.ValidateToken.Application.DTOs;
using TDonCashless.Microservices.ValidateToken.Application.Interfaces;
using TDonCashless.Microservices.ValidateToken.Domain.Commands;
using TDonCashless.Microservices.ValidateToken.Domain.Interfaces;
using TDonCashless.Microservices.ValidateToken.Domain.Models;

namespace TDonCashless.Microservices.ValidateToken.Application.Services
{
    public class ValidateTokenService : IValidateTokenService
    {
        private readonly IValidatedTokenRepository _validatedTokenRepository;
        private readonly IEventBus _bus;

        public ValidateTokenService(IValidatedTokenRepository validatedTokenRepository, IEventBus bus)
        {
            _validatedTokenRepository = validatedTokenRepository;
            _bus = bus;
        }
        public IEnumerable<ValidatedToken> GetValidatedTokenHistory()
        {
            return _validatedTokenRepository.GetValidatedTokens();
        }

        public void ValidateToken(ValidateTokenDTO validateToken)
        {
            var initiateValidateTokenCommand = new InitiateValidateTokenCommand(
                    validateToken.CustomerId,
                    validateToken.CustomerCardId,
                    validateToken.Token,
                    validateToken.CVV
                );

            _bus.SendCommand(initiateValidateTokenCommand);
        }
    }
}