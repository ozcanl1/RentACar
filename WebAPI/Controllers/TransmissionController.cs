using Business.Abstract;
using Fuel.Requests;
using Fuel.Responses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransmissionController : ControllerBase
    {
        private readonly ITransmissionService _transmissionService;

        public TransmissionController()
        {
            _transmissionService = ServiceRegistration.TransmissionService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Entities.Concrete.Transmission>> GetList()
        {
            try
            {
                IEnumerable<Entities.Concrete.Transmission> transmissionList = _transmissionService.GetList();
                return Ok(transmissionList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpPost]
        public ActionResult<AddTransmissionResponse> Add([FromBody] AddTransmissionRequest request)
        {
            try
            {
                AddTransmissionResponse response = _transmissionService.Add(request);
                return CreatedAtAction(nameof(GetList), response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
    }
}
