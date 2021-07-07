using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TdonCashless.Microservices.Gateway.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValidateTokenGatewayController : ControllerBase
    {
        public ValidateTokenGatewayController() { }

        [HttpPost]
        public void Post()
        {
        }
    }
}