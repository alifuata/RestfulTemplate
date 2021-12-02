using AfaRestApi.Data;
using AfaRestApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfaRestApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController] //bu tag ModelState.Isvalid işlemini tüm metodlar için yapar
    public class CarController : Controller
    {
        /// <summary>
        /// Get All cars in the DB
        /// </summary>
        /// <returns>AR with Data</returns>
        [HttpGet]
        public IActionResult Get()
        {
            var allCars = FakeDataCars.GetAllCars();
            return Ok(allCars);
        }
        /// <summary>
        /// Get Spesific Car
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var car = FakeDataCars.GetCar(id);
            if (car == null) return NotFound();
            else return Ok(car);

        }
        /// <summary>
        /// Add new car 
        /// </summary>
        /// <param name="car"></param>
        /// <returns>Car with ID</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Car car)
        {
            if (ModelState.IsValid)
            {
                var newCar = FakeDataCars.InsertCar(car);
                return Ok(newCar);
            }
            return BadRequest(ModelState);
        }
    }
}
