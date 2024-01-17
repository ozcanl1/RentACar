public class FuelService
{
    private InMemoryFuelDal _fuelDal;

    public FuelService(InMemoryFuelDal fuelDal)
    {
        _fuelDal = fuelDal;
    }

    public List<Fuel> GetAll()
    {
        return _fuelDal.GetAll();
    }

    public Fuel GetById(int id)
    {
        return _fuelDal.GetById(id);
    }

    public void Add(Fuel fuel)
    {
        _fuelDal.Add(fuel);
    }

    public void Update(Fuel fuel)
    {
        _fuelDal.Update(fuel);
    }

    public void Delete(int id)
    {
        _fuelDal.Delete(id);
    }
}
