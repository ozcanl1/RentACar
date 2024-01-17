using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Runtime.InteropServices;

[Route("api/[controller]")]
[ApiController]
public class FuelController : ControllerBase
{
    private readonly FuelService _fuelService;

    public FuelController(FuelService fuelService)
    {
        _fuelService = fuelService;
    }

    [HttpGet]
    public ActionResult<List<Fuel>> Get()
    {
        return _fuelService.GetAllFuels();
    }

    [HttpGet("{id}")]
    public ActionResult<Fuel> Get(int id)
    {
        var fuel = _fuelService.GetFuelById(id);

        if (fuel == null)
        {
            return NotFound();
        }

        return fuel;
    }

    [HttpPost]
    public IActionResult Post(Fuel fuel)
    {
        try
        {
            _fuelService.AddFuel(fuel);
            return Ok();
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ex.Message);
        }
    }

}
