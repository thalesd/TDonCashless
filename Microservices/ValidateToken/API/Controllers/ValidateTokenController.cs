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
    public class ValidatedTokenController : ControllerBase
    {
        private readonly IValidatedTokenService _validatedTokenService;

        public ValidatedTokenController(IValidatedTokenService validatedTokenService)
        {
            _validatedTokenService = validatedTokenService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ValidatedToken>> Get(){
            return Ok(_validatedTokenService.GetValidatedTokenHistory());
        }

        [HttpPost]
        public Task<bool> Post([FromBody] InsertValidatedTokenDTO validateToken){
            _validatedTokenService.InsertValidatedToken(validateToken);
            
            return Task.FromResult(false);
        }
    }
}
