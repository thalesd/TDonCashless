using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TDonCashless.Microservices.ValidateToken.Application.DTOs;
using TDonCashless.Microservices.ValidateToken.Application.Interfaces;

namespace TDonCashless.Microservices.ValidateToken.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidateTokenController : ControllerBase
    {
        private readonly ILogger<ValidateTokenController> _logger;
        private readonly IValidateTokenService _validateTokenService;

        public ValidateTokenController(ILogger<ValidateTokenController> logger, IValidateTokenService validateTokenService)
        {
            _logger = logger;
            _validateTokenService = validateTokenService;
        }

        [HttpPost]
        public ActionResult<ValidatedTokenDTO> Post([FromBody] ValidateTokenDTO validateToken){
            var result = _validateTokenService.ValidateToken(validateToken);
            
            return Ok(result);
        }
    }
}
