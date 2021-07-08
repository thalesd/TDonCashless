using System.Threading.Tasks;
using TdonCashless.Microservices.Gateway.API.DTOs;

namespace TdonCashless.Microservices.Gateway.API.Services
{
    public interface ICreateCustomerCardService
    {
        Task<CreatedCard> CreateCard(CreateCardDTO createCardDto);
    }
}