
using Business.Responses.TransmissionResponse;
using Fuel.Requests;
using Fuel.Responses;

namespace Business.Abstract
{
    public interface ITransmissionService
    {
        public AddTransmissionResponse Add(AddTransmissionRequest addTransmissionRequest);
        public IList<AddTransmissionResponse> GetList();
        public AddTransmissionResponse GetById(int id);
        public AddTransmissionResponse Update(int id, AddTransmissionRequest transmissionRequest);
        public AddTransmissionResponse Delete(int id);
    }
}