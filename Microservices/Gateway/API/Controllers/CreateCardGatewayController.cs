using System.Threading.Tasks;
using TdonCashless.Microservices.Gateway.API.DTOs;
using TdonCashless.Microservices.Gateway.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace TdonCashless.Microservices.Gateway.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreateCardGatewayController : ControllerBase
    {
        private readonly ICreateCustomerCardService _createCustomerCardService;

        public CreateCardGatewayController(ICreateCustomerCardService createCustomerCardService)
        {
            _createCustomerCardService = createCustomerCardService;
        }

        [HttpPost]
        public async Task<JsonResult> Post([FromBody] CreateCardDTO createCardDto)
        {
            var createdCard = await _createCustomerCardService.CreateCard(createCardDto);

            return new JsonResult(createdCard);
        }
    }
}
