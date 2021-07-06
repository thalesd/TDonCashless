using System.Threading.Tasks;

namespace TDonCashless.Domain.Core.Events
{
    public interface IEventHandler<in TEvent> : IEventHandler where TEvent: Event
    {
        Task HandleAsync(TEvent @event);
    }

    public interface IEventHandler
    {
        
    }
}