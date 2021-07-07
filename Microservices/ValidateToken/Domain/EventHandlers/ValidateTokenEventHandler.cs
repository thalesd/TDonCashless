using System;
using System.Threading.Tasks;
using TDonCashless.Domain.Core.Events;
using TDonCashless.Microservices.ValidateToken.Domain.Events;
using TDonCashless.Microservices.ValidateToken.Domain.Interfaces;
using TDonCashless.Microservices.ValidateToken.Domain.Models;

namespace TDonCashless.Microservices.ValidateToken.Domain.EventHandlers
{
    public class ValidateTokenEventHandler : IEventHandler<ValidateTokenInitiatedEvent>
    {
        private readonly IValidatedTokenRepository _validatedTokenRepository;
        
        public ValidateTokenEventHandler(IValidatedTokenRepository validatedTokenRepository)
        {
            _validatedTokenRepository = validatedTokenRepository;
        }

        public Task HandleAsync(ValidateTokenInitiatedEvent @event)
        {
            

            _validatedTokenRepository.InsertNewValidatedToken(new ValidatedToken(){
                CardId = @event.CustomerCardId,
                CustomerId = @event.CustomerId,
                Valid = false,
                ValidatedTime = DateTime.Now
            });

            return Task.CompletedTask;
        }
    }
}