public class FuelService
{
    private InMemoryDal<Fuel> _fuelDal;

    public FuelService()
    {
        _fuelDal = new InMemoryDal<Fuel>();
    }

    public void AddFuel(Fuel fuel)
    {
  
        if (!HasDuplicateName(fuel.Name))
        {
            _fuelDal.Add(fuel);
            Console.WriteLine("Fuel added: " + fuel.Name);
        }
        else
        {
            Console.WriteLine("Fuel with the same name already exists: " + fuel.Name);
        }
    }


    public bool HasDuplicateName(string name)
    {
        return _fuelDal.GetAll().Any(f => f.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

}
