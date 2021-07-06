using Microsoft.Extensions.DependencyInjection;
using TDonCashless.BusLayer;
using TDonCashless.Domain.Core.Bus;

namespace IOCLayer
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services){
            //DomainBus
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}