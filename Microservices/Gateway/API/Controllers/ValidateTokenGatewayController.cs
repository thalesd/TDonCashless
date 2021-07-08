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
    public class ValidateTokenGatewayController : ControllerBase
    {
        private readonly IValidateTokenService _validateTokenService;
        public ValidateTokenGatewayController(IValidateTokenService validateTokenService)
        {
            _validateTokenService = validateTokenService;
        }

        [HttpPost]
        public async Task<bool> Post([FromBody] ValidateCardDTO validateCardDto)
        {
            await _validateTokenService.ValidateCard(validateCardDto);

            return false;
        }
    }
}