using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TDonCashless.Microservices.CreateCustomerCard.Application.DTOs;
using TDonCashless.Microservices.CreateCustomerCard.Application.Interfaces;
using TDonCashless.Microservices.CreateCustomerCard.Data.Repository;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Models;

namespace TDonCashless.Microservices.CreateCustomerCard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateCustomerCardController : ControllerBase
    {
        private readonly ICustomerCardService _customerCardService;

        public CreateCustomerCardController(ICustomerCardService customerCardService)
        {
            _customerCardService = customerCardService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CustomerCard>> Get()
        {
            return Ok(_customerCardService.GetCustomerCards());
        }

        [HttpGet]
        public ActionResult<IEnumerable<CustomerCard>> Get([FromQuery] int customerCardId)
        {
            return Ok(_customerCardService.GetCustomerCardById(customerCardId));
        }

        [HttpPost]
        public ActionResult<CustomerCardCreatedDTO> Post([FromBody] CustomerCardCreationDTO customerCard){
            _customerCardService.CreateCustomerCard(customerCard);

            return Ok(customerCard);
        }
    }
}
