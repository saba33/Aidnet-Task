using Aidnet_Task.Models.Dtos;
using Aidnet_Task.Models.Requests;
using AutoShop_Services.Abstraction;
using AutoShop_Services.Implementation;
using AutoShop_Services.Models.Car;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aidnet_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IAutoService _carServices;
        public CarController(IAutoService carservice)
        {
            _carServices = carservice;
        }

        [HttpPost]
        public IActionResult PostCar(CreateCarRequest request)
        {
            var carToInsert = request.Adapt<CarServiceModel>();
            var result = _carServices.Create(carToInsert);
            if (result == false)
                return BadRequest();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var result = _carServices.Get(id);
            return Ok(result.Adapt<CarDto>());
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var resut = _carServices.GetAll();
            return Ok(resut.Adapt<List<CarDto>>());
        }

        [HttpDelete("id")]
        public IActionResult Delete(Guid id)
        {
            var result = _carServices.Delete(id);
            if(result == false)
            {
                return BadRequest();
            }

            return Ok(true);
        }

        [HttpPut("{id}")]
        public IActionResult Put(UpdateCarRequest model, Guid id)
        {
            var result = _carServices.Get(id);
            if(result == null)
            {
                return BadRequest();
            }

            _carServices.Update(id, result.Adapt<CarServiceModel>());
            return Ok();
        }

    }
}
