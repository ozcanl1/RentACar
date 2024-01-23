using Business;
using Business.Abstract;
using Business.Concrete;
using Business.Requests.Model;
using Business.Responses.Model;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ModelsController : ControllerBase
{
    private readonly ModelService _modelService; // Field

    public ModelsController(ModelService modelService)
    {
        // Her HTTP Request için yeni bir Controller nesnesi oluşturulur.
        _modelService = ServiceRegistration.ModelService;
        // Daha sonra IoC Container yapımızı kurduğumuz Dependency Injection ile daha verimli hale getiricez.
    }

    //[HttpGet]
    //public ActionResult<string> //IActionResult
    //GetList()
    //{
    //    return Ok("BrandsController");
    //}

    [HttpGet] // GET http://localhost:5245/api/brands
    public ICollection<Model> GetList()
    {
        IList<Model> modelList = _modelService.GetList();
        return modelList; // JSON
    }

    //[HttpPost("/add")] // POST http://localhost:5245/api/brands/add
    [HttpPost] // POST http://localhost:5245/api/brands
    public ActionResult<AddModelResponse> Add(AddModelRequest request)
    {
        try
        {
            AddModelResponse response = _modelService.Add(request);

            //return response; // 200 OK
            return CreatedAtAction(nameof(GetList), response); // 201 Created
        }
        catch (Core.CrossCuttingConcerns.Exceptions.BusinessException exception)
        {
            return BadRequest(
                new Core.CrossCuttingConcerns.Exceptions.BusinessProblemDetails()
                {
                    Title = "Business Exception",
                    Status = StatusCodes.Status400BadRequest,
                    Detail = exception.Message,
                    Instance = HttpContext.Request.Path
                }
            );
            // 400 Bad Request
        }

    }
    [HttpDelete]
    public ActionResult Delete(int id)
    {

        _modelService.DeleteModel(id);
        return Ok();
    }
}
