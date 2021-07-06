using System.Threading.Tasks;

namespace TDonCashless.Domain.Core.Commands
{
    public interface ICommandHandler<in T> where T : ICommand
    {
        Task HandleAsync(T command);
    }
}