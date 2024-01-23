using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Car;
using Business.Requests.Car;
using Business.Responses.Car;
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
            Entities.Concrete.Car carAdd = _mapper.Map<Entities.Concrete.Car>(request); 

            _IcarDal.Add(carAdd);

            AddCarResponse response = _mapper.Map<AddCarResponse>(carAdd);
            return response;

        }

    public AddCarResponse Add(AddCarResponse request)
    {
        throw new NotImplementedException();
    }

    public DeleteCarResponse Delete(DeleteCarRequest request)
    {
        throw new NotImplementedException();
    }

    public void DeleteModel(int id)
    {
        throw new NotImplementedException();
    }

    public GetCarByIdResponse GetById(GetCarByIdRequest request)
    {
        throw new NotImplementedException();
    }

    public IList<Entities.Concrete.Car> GetList()
        {
            IList<Entities.Concrete.Car> Cars = _IcarDal.GetList();
            return Cars;
        }

    public UpdateCarResponse Update(UpdateCarRequest request)
    {
        throw new NotImplementedException();
    }

    IList<Model> CarService.GetList()
    {
        throw new NotImplementedException();
    }
}


