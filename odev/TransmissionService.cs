public class TransmissionService
{
    private InMemoryTransmissionDal _transmissionDal;

    public TransmissionService(InMemoryTransmissionDal transmissionDal)
    {
        _transmissionDal = transmissionDal;
    }

    public List<Transmission> GetAll()
    {
        return _transmissionDal.GetAll();
    }

    public Transmission GetById(int id)
    {
        return _transmissionDal.GetById(id);
    }

    public void Add(Transmission transmission)
    {
        _transmissionDal.Add(transmission);
    }

    public void Update(Transmission transmission)
    {
        _transmissionDal.Update(transmission);
    }

    public void Delete(int id)
    {
        _transmissionDal.Delete(id);
    }
}
