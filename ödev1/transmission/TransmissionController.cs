using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Runtime.InteropServices;

[Route("api/[controller]")]
[ApiController]
public class TransmissionController : ControllerBase
{
    private readonly TransmissionService _transmissionService;

    public TransmissionController(TransmissionService transmissionService)
    {
        _transmissionService = transmissionService;
    }

    [HttpGet]
    public ActionResult<List<Transmission>> Get()
    {
        return _transmissionService.GetAllTransmissions();
    }

    [HttpGet("{id}")]
    public ActionResult<Transmission> Get(int id)
    {
        var transmission = _transmissionService.GetTransmissionById(id);

        if (transmission == null)
        {
            return NotFound();
        }

        return transmission;
    }

    [HttpPost]
    public IActionResult Post(Transmission transmission)
    {
        try
        {
            _transmissionService.AddTransmission(transmission);
            return Ok();
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
