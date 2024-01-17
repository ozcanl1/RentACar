public class FuelService
{
    private readonly InMemoryFuelDal _fuelDal;

    public FuelService(InMemoryFuelDal fuelDal)
    {
        _fuelDal = fuelDal;
    }

    public List<Fuel> GetAllFuels()
    {
        return _fuelDal.GetAll();
    }

    public Fuel GetFuelById(int id)
    {
        return _fuelDal.GetById(id);
    }

    public void AddFuel(Fuel fuel)
    {
        _fuelDal.Add(fuel);
    }
}