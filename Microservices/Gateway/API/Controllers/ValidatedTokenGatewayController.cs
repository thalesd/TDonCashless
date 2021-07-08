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
        public async Task<bool> Post([FromBody] RevalidateCustomerCardTokenDTO revalidateCustomerCardDto)
        {
            await _validateTokenService.ValidateCard(revalidateCustomerCardDto);

            return false;
        }
    }
}