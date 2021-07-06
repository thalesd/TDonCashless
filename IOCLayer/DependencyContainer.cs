using Microsoft.Extensions.DependencyInjection;
using TDonCashless.BusLayer;
using TDonCashless.Domain.Core.Bus;
using TDonCashless.Microservices.CreateCustomerCard.Application.Interfaces;
using TDonCashless.Microservices.CreateCustomerCard.Application.Services;
using TDonCashless.Microservices.CreateCustomerCard.Data.Context;
using TDonCashless.Microservices.CreateCustomerCard.Data.Repository;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Interfaces;

namespace IOCLayer
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services){
            //DomainBus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Application Layer
            services.AddTransient<ICustomerCardService, CustomerCardService>();

            //Data Layer
            services.AddTransient<ICustomerCardRepository, CustomerCardRepository>();
            services.AddTransient<CustomerCardDbContext>();
        }
    }
}