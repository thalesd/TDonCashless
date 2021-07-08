using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TdonCashless.Microservices.Gateway.API.DTOs;
using TdonCashless.Microservices.Gateway.API.Services;

namespace TdonCashless.Microservices.Gateway.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValidatedTokenGatewayController : ControllerBase
    {
        private readonly IValidatedTokenService _validateTokenService;
        public ValidatedTokenGatewayController(IValidatedTokenService validateTokenService)
        {
            _validateTokenService = validateTokenService;
        }

        [HttpPost]
        public async Task<JsonResult> Post([FromBody] RevalidateCustomerCardTokenDTO revalidateCustomerCardDto)
        {
            return new JsonResult(new { Validated = await _validateTokenService.ValidateCard(revalidateCustomerCardDto)});
        }
    }
}