using System.Threading.Tasks;

namespace TDonCashless.Domain.Core.Events
{
    public interface IEventHandler<in T> where T : IEvent
    {
        Task HandleAsync(T @event);
    }
}