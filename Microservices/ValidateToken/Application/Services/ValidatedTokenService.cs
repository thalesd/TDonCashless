using System.Collections.Generic;
using System.Threading.Tasks;
using TDonCashless.Domain.Core.Bus;
using TDonCashless.Microservices.ValidateToken.Application.DTOs;
using TDonCashless.Microservices.ValidateToken.Application.Interfaces;
using TDonCashless.Microservices.ValidateToken.Domain.Commands;
using TDonCashless.Microservices.ValidateToken.Domain.Interfaces;
using TDonCashless.Microservices.ValidateToken.Domain.Models;

namespace TDonCashless.Microservices.ValidateToken.Application.Services
{
    public class ValidatedTokenService : IValidatedTokenService
    {
        private readonly IValidatedTokenRepository _validatedTokenRepository;
        private readonly IEventBus _bus;

        public ValidatedTokenService(IValidatedTokenRepository validatedTokenRepository, IEventBus bus)
        {
            _validatedTokenRepository = validatedTokenRepository;
            _bus = bus;
        }
        public IEnumerable<ValidatedToken> GetValidatedTokenHistory()
        {
            return _validatedTokenRepository.GetValidatedTokens();
        }

        public async Task InsertValidatedToken(InsertValidatedTokenDTO insertValidatedToken)
        {
            var initiateValidateTokenCommand = new InitiateInsertValidatedTokenCommand(
                    insertValidatedToken.CustomerId,
                    insertValidatedToken.CustomerCardId,
                    insertValidatedToken.Token,
                    insertValidatedToken.CVV,
                    insertValidatedToken.Validated
                );

            await _bus.SendCommand(initiateValidateTokenCommand);
        }
    }
}