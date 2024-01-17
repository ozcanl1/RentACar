using AutoMapper;
using DataAccess.Abstract;
using Entities.Concrete;
using Fuel.Requests;
using Fuel.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.Concrete
{
    public class FuelManager : IFuelService
    {
        private readonly IFuelDal _IfuelDal;
        private readonly IMapper _mapper;

        public FuelManager(IFuelDal fueldDal, IMapper mapper)
        {
            _IfuelDal = fueldDal; //new InMemoryBrandDal(); // Başka katmanların class'ları new'lenmez. Bu yüzden dependency injection kullanıyoruz.
        
            _mapper = mapper;
        }
        public AddFuelResponse Add(AddFuelRequest request)
        {
         Entities.Concrete.Fuel fuelAdd = _mapper.Map<Entities.Concrete.Fuel>(request); // Mapping

            _IfuelDal.Add(fuelAdd);

            AddFuelResponse response = _mapper.Map<AddFuelResponse>(fuelAdd);
            return response;
      
        }

        public IList<Entities.Concrete.Fuel> GetList()
        {
          IList<Entities.Concrete.Fuel> fuels=_IfuelDal.GetList();
            return fuels;
        }
    }

}
