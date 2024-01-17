public class GearboxService
{
    private readonly InMemoryGearboxDal _gearboxDal;

    public GearboxService(InMemoryGearboxDal gearboxDal)
    {
        _gearboxDal = gearboxDal;
    }

    public List<Gearbox> GetAllGearboxes()
    {
        return _gearboxDal.GetAll();
    }

    public Gearbox GetGearboxById(int id)
    {
        return _gearboxDal.GetById(id);
    }

    public void AddGearbox(Gearbox gearbox)
    {
        _gearboxDal.Add(gearbox);
    }
}
