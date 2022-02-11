using Aidnet_Task.Models;
using Aidnet_Task.Models.Dtos;
using Aidnet_Task.Models.Requests;
using AutoShop_Services.Abstraction;
using AutoShop_Services.Models.CarFeatures;
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
    public class CarFeaturesController : ControllerBase
    {
        private readonly ICarFeaturesService _carFeaturesServices;
        public CarFeaturesController(ICarFeaturesService carFeaturesService)
        {
            _carFeaturesServices = carFeaturesService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Guid id, CreateCarFeaturesRequest model)
        {
            var carFeatureToInsert = model.Adapt<CarFeaturesServiceModel>();
            var result = await Task.FromResult(_carFeaturesServices.Create(carFeatureToInsert, id));
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid carId)
        {
            var result = await _carFeaturesServices.Get(carId);
            if (result != null)
            {
                return Ok(result.Adapt<CarFeaturesDto>());
            }
            else
                return BadRequest();
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _carFeaturesServices.GetAll();
            if (result != null)
            {
                return Ok(result.Adapt<List<CarFeaturesDto>>());
            }
            else
                return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var carToDelete = await _carFeaturesServices.Get(id);
            if (carToDelete != null)
            {
                return Ok(await _carFeaturesServices.Delete(id));
            }
            else
                return BadRequest();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, UpdateCarFeaturesRequest model)
        {
            var result = _carFeaturesServices.Get(id);
            var modelForupdate = model.Adapt<CarFeaturesServiceModel>();
            if (result != null)
            {
                return Ok(await _carFeaturesServices.Update(id, modelForupdate));
            }
            else
                return BadRequest();
        }
    }
}
