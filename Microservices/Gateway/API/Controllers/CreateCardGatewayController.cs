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
    public class CreateCardGatewayController : ControllerBase
    {
        public CreateCardGatewayController() { }

        [HttpPost]
        public void Post()
        {
        }
    }
}
