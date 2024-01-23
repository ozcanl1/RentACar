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

namespace Transmission.Concrete
{
    public class TransmissionManager : ITransmissionService
    {
        private readonly ITransmissionDal _ItransmissionDal;
        private readonly IMapper _mapper;

        public TransmissionManager(ITransmissionDal transmissiondDal, IMapper mapper)
        {
            _ItransmissionDal = transmissiondDal; //new InMemoryBrandDal(); // Başka katmanların class'ları new'lenmez. Bu yüzden dependency injection kullanıyoruz.

            _mapper = mapper;
        }
        public AddTransmissionResponse Add(AddTransmissionRequest request)
        {
            Entities.Concrete.Transmission transmissionAdd = _mapper.Map<Entities.Concrete.Transmission>(request); // Mapping

            _ItransmissionDal.Add(transmissionAdd);

            AddTransmissionResponse response = _mapper.Map<AddTransmissionResponse>(transmissionAdd);
            return response;

        }

        public IList<Entities.Concrete.Transmission> GetList()
        {
            IList<Entities.Concrete.Transmission> transmissions = _ItransmissionDal.GetList();
            return transmissions;
        }
    }

}
