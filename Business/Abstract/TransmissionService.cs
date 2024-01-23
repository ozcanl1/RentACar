using Fuel.Requests;
using Fuel.Responses;


public interface ITransmissionService
{

    public AddTransmissionResponse Add(AddTransmissionRequest request);

    public IList<Entities.Concrete.Transmission> GetList();


}