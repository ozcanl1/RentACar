using Business.Requests.Car;
using Business.Responses.Car;
using Entities.Concrete;



public interface ICarService
{

    public AddCarResponse Add(AddCarRequest request);

    public IList<Entities.Concrete.Car> GetList();


}