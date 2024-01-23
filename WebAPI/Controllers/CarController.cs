using Business;
using Business.Abstract;
using Business.Concrete;
using Business.Requests.Car;
using Business.Responses.Car;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly CarService _carService; // Field
        public CarController()
        {
            _carService = ServiceRegistration.CarService;
        }

        [HttpGet] // GET http://localhost:5245/api/brands
        public ICollection<Entities.Concrete.Car> GetList()
        {
            IList<Entities.Concrete.Car> carlist = (IList<Car>)_carService.GetList();
            return carlist; // JSON
        }
        [HttpPost]
        public ActionResult<AddCarResponse> Add(AddCarRequest request)
        {
            AddCarResponse response = _carService.Add(request);

            //return response; // 200 OK
            return CreatedAtAction(nameof(GetList), response); // 2

        }
        [HttpDelete]
        public ActionResult<AddCarResponse> Delete(int id)
        {
            _carService.DeleteCar(id);
            return Ok();
        }

    }
}
