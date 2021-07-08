using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TDonCashless.Microservices.CreateCustomerCard.Application.DTOs;
using TDonCashless.Microservices.CreateCustomerCard.Application.Interfaces;

namespace TDonCashless.Microservices.CreateCustomerCard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RevalidateCustomerCardToken : ControllerBase
    {
        private readonly ICustomerCardService _customerCardService;

        public RevalidateCustomerCardToken(ICustomerCardService customerCardService)
        {
            _customerCardService = customerCardService;
        }

        [HttpPost]
        public async Task<JsonResult> Post([FromBody] RevalidateCustomerCardTokenDTO revalidateCustomerCardToken)
        {
            return new JsonResult(await _customerCardService.RevalidateCustomerCardToken(revalidateCustomerCardToken));
        }
    }
}