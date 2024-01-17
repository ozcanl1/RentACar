using Fuel.Requests;
using Fuel.Responses;


public  interface IFuelService
{

    public AddFuelResponse Add(AddFuelRequest request);

   public IList<Entities.Concrete.Fuel> GetList();

  
}