using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using zCzosnkowym.Api.Models;
using zCzosnkowym.DataAccess.Interfaces;

namespace zCzosnkowym.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        private readonly IRestaurantRepository _repository;
        private readonly IMapper _mapper;

        public OrdersController(IRestaurantRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDto>>> Get()
        {
            try
            {
                var ordersFromRepo = await _repository.GetAll();
                return Ok(_mapper.Map<IEnumerable<OrderDto>>(ordersFromRepo));
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
    }
}