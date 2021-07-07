using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TDonCashless.Microservices.ValidateToken.Application.DTOs;
using TDonCashless.Microservices.ValidateToken.Application.Interfaces;
using TDonCashless.Microservices.ValidateToken.Domain.Models;

namespace TDonCashless.Microservices.ValidateToken.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidateTokenController : ControllerBase
    {
        private readonly IValidateTokenService _validateTokenService;

        public ValidateTokenController(IValidateTokenService validateTokenService)
        {
            _validateTokenService = validateTokenService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ValidatedToken>> Get(){
            return Ok(_validateTokenService.GetValidatedTokenHistory());
        }

        [HttpPost]
        public ActionResult<ValidatedTokenDTO> Post([FromBody] ValidateTokenDTO validateToken){
            _validateTokenService.ValidateToken(validateToken);
            
            return Ok(validateToken);
        }
    }
}
