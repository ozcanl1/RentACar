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

    public class CarManager : ICarService
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

        public IList<Entities.Concrete.Car> GetList()
        {
            IList<Entities.Concrete.Car> Cars = _IcarDal.GetList();
            return Cars;
        }
    }


