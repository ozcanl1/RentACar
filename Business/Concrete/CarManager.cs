using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Car;
using Business.Responses.Brand;
using Business.Responses.Car;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CarManager : CarService
{
    private readonly ICarDal _IcarDal;
    private readonly IMapper _mapper;

    public CarManager(ICarDal cardDal, IMapper mapper)
    {
        _IcarDal = cardDal;

        _mapper = mapper;
    }

    public AddCarResponse Add(AddCarRequest request)
    {
        Car addCar = _mapper.Map<Car>(request); // Mapping

        _IcarDal.Add(addCar);

        AddCarResponse response = _mapper.Map<AddCarResponse>(addCar);
        return response;
    }

    public DeleteCarResponse Delete(DeleteCarRequest request)
    {
        throw new NotImplementedException();
    }

    public void DeleteCar(int id)
    {
        throw new NotImplementedException();
    }

    public void DeleteModel(int id)
    {
        var result = _IcarDal.GetList(id);
        _IcarDal.Delete(result);
    }

    public GetCarByIdResponse GetById(GetCarByIdRequest request)
    {
        throw new NotImplementedException();
    }

    public IList<Car> GetList()
    {
        var carResponse=_IcarDal.GetList();
        return carResponse;
    }

    public UpdateCarResponse Update(UpdateCarRequest request)
    {
        throw new NotImplementedException();
    }
}


