using Entities.Concrete;

namespace WebAPI.Controllers
{
    internal interface ICarlService
    {
        IList<Car> GetList();
    }
}