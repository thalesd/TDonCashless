using MediatR;
using Microsoft.Extensions.DependencyInjection;
using TDonCashless.BusLayer;
using TDonCashless.Domain.Core.Bus;
using TDonCashless.Microservices.CreateCustomerCard.Application.Interfaces;
using TDonCashless.Microservices.CreateCustomerCard.Application.Services;
using TDonCashless.Microservices.CreateCustomerCard.Data.Context;
using TDonCashless.Microservices.CreateCustomerCard.Data.Repository;
using TDonCashless.Microservices.CreateCustomerCard.Domain.CommandHandlers;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Commands;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Interfaces;
using TDonCashless.Microservices.ValidateToken.Application.Interfaces;
using TDonCashless.Microservices.ValidateToken.Application.Services;
using TDonCashless.Microservices.ValidateToken.Data.Context;
using TDonCashless.Microservices.ValidateToken.Data.Repository;
using TDonCashless.Microservices.ValidateToken.Domain.CommandHandlers;
using TDonCashless.Microservices.ValidateToken.Domain.Commands;
using TDonCashless.Microservices.ValidateToken.Domain.Interfaces;

namespace IOCLayer
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //DomainBus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Domain CreateCustomerCard Commands
            services.AddTransient<IRequestHandler<InitiateCreateCardCommand, bool>, CreateCardCommandHandler>();
            services.AddTransient<IRequestHandler<InitiateValidateTokenCommand, bool>, ValidateTokenCommandHandler>();

            //Application Layer
            services.AddTransient<ICustomerCardService, CustomerCardService>();
            services.AddTransient<IValidateTokenService, ValidateTokenService>();

            //Data Layer
            services.AddTransient<ICustomerCardRepository, CustomerCardRepository>();
            services.AddTransient<IValidatedTokenRepository, ValidatedTokenRepository>();
            services.AddTransient<CustomerCardDbContext>();
            services.AddTransient<ValidatedTokenDbContext>();
        }
    }
}