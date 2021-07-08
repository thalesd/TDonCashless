using MediatR;
using Microsoft.Extensions.DependencyInjection;
using TDonCashless.BusLayer;
using TDonCashless.Domain.Core.Bus;
using TDonCashless.Domain.Core.Events;
using TDonCashless.Microservices.CreateCustomerCard.Application.Interfaces;
using TDonCashless.Microservices.CreateCustomerCard.Application.Services;
using TDonCashless.Microservices.CreateCustomerCard.Data.Context;
using TDonCashless.Microservices.CreateCustomerCard.Data.Repository;
using TDonCashless.Microservices.CreateCustomerCard.Domain.CommandHandlers;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Commands;
using TDonCashless.Microservices.CreateCustomerCard.Domain.EventHandlers;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Events;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Interfaces;
using TDonCashless.Microservices.ValidateToken.Application.Interfaces;
using TDonCashless.Microservices.ValidateToken.Application.Services;
using TDonCashless.Microservices.ValidateToken.Data.Context;
using TDonCashless.Microservices.ValidateToken.Data.Repository;
using TDonCashless.Microservices.ValidateToken.Domain.CommandHandlers;
using TDonCashless.Microservices.ValidateToken.Domain.Commands;
using TDonCashless.Microservices.ValidateToken.Domain.EventHandlers;
using TDonCashless.Microservices.ValidateToken.Domain.Events;
using TDonCashless.Microservices.ValidateToken.Domain.Interfaces;

namespace IOCLayer
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //DomainBus
            services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });

            //Subscriptions
            services.AddTransient<InsertValidatedTokenEventHandler>();
            services.AddTransient<CreateCardEventHandler>();

            //Domain Events
            services.AddTransient<IEventHandler<InsertValidatedTokenInitiatedEvent>, InsertValidatedTokenEventHandler>();
            services.AddTransient<IEventHandler<CreateCardInitiatedEvent>, CreateCardEventHandler>();

            //Domain Commands
            services.AddTransient<IRequestHandler<InitiateCreateCardCommand, bool>, CreateCardCommandHandler>();
            services.AddTransient<IRequestHandler<InitiateInsertValidatedTokenCommand, bool>, InsertValidatedTokenCommandHandler>();

            //Application Layer
            services.AddTransient<ICustomerCardService, CustomerCardService>();
            services.AddTransient<IValidatedTokenService, ValidatedTokenService>();

            //Data Layer
            services.AddTransient<ICustomerCardRepository, CustomerCardRepository>();
            services.AddTransient<IValidatedTokenRepository, ValidatedTokenRepository>();
            services.AddTransient<CustomerCardDbContext>();
            services.AddTransient<ValidatedTokenDbContext>();
        }
    }
}