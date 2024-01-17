using Business.Abstract;
using Business.Requests.Brand;
using Business.Responses.Brand;
using Entities.Concrete;
using Fuel.Requests;
using Fuel.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelController : ControllerBase
    {
        private readonly IFuelService _fuelService; // Field
        public FuelController()
        {
            _fuelService = ServiceRegistration.FuelService;
        }

        [HttpGet] // GET http://localhost:5245/api/brands
        public ICollection<Entities.Concrete.Fuel> GetList()
        {
            IList<Entities.Concrete.Fuel> fuellist = _fuelService.GetList();
            return fuellist; // JSON
        }
        [HttpPost] 
        public ActionResult<AddFuelResponse> Add(AddFuelRequest request)
        {
            AddFuelResponse response = _fuelService.Add(request);

            //return response; // 200 OK
            return CreatedAtAction(nameof(GetList), response); // 2
         
        }

    }
}
