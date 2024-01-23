using Business.Requests.Brand;
using Business.Requests.Car;
using Business.Responses.Brand;
using Business.Responses.Car;
using Business.Responses.Model;
using Entities.Concrete;

namespace Business.Abstract;

public interface CarService
{
    //public AddCarResponse Add(AddCarResponse request);

    public GetCarByIdResponse GetById(GetCarByIdRequest request);

    public AddCarResponse Add(AddCarRequest request);

    public UpdateCarResponse Update(UpdateCarRequest request);

    public DeleteCarResponse Delete(DeleteCarRequest request);
    IList<Car> GetList();
    void DeleteCar(int id);
}
