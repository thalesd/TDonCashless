using System;
using System.Threading.Tasks;
using TDonCashless.Domain.Core.Events;
using TDonCashless.Microservices.ValidateToken.Domain.Events;
using TDonCashless.Microservices.ValidateToken.Domain.Interfaces;
using TDonCashless.Microservices.ValidateToken.Domain.Models;

namespace TDonCashless.Microservices.ValidateToken.Domain.EventHandlers
{
    public class InsertValidatedTokenEventHandler : IEventHandler<InsertValidatedTokenInitiatedEvent>
    {
        private readonly IValidatedTokenRepository _validatedTokenRepository;
        
        public InsertValidatedTokenEventHandler(IValidatedTokenRepository validatedTokenRepository)
        {
            _validatedTokenRepository = validatedTokenRepository;
        }

        public Task HandleAsync(InsertValidatedTokenInitiatedEvent @event)
        {
            _validatedTokenRepository.InsertNewValidatedToken(new ValidatedToken(){
                CardId = @event.CustomerCardId,
                CustomerId = @event.CustomerId,
                Token = @event.Token,
                CVV = @event.CVV,
                Valid = @event.Validated,
                ValidatedLogTime = DateTime.Now.ToUniversalTime()
            });

            return Task.CompletedTask;
        }
    }
}