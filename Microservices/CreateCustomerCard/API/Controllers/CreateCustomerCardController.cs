using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TDonCashless.Microservices.CreateCustomerCard.Application.Interfaces;
using TDonCashless.Microservices.CreateCustomerCard.Data.Repository;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Models;

namespace TDonCashless.Microservices.CreateCustomerCard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateCustomerCardController : ControllerBase
    {
        private readonly ILogger<CreateCustomerCardController> _logger;
        private readonly ICustomerCardService _customerCardService;

        public CreateCustomerCardController(ILogger<CreateCustomerCardController> logger, ICustomerCardService customerCardService)
        {
            _logger = logger;
            _customerCardService = customerCardService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CustomerCard>> Get()
        {
            return Ok(_customerCardService.GetCustomerCards());
        }
    }
}
