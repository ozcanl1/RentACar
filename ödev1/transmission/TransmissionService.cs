public class TransmissionService
{
    private readonly InMemoryTransmissionDal _transmissionDal;

    public TransmissionService(InMemoryTransmissionDal transmissionDal)
    {
        _transmissionDal = transmissionDal;
    }

    public List<Transmission> GetAllTransmissions()
    {
        return _transmissionDal.GetAll();
    }

    public Transmission GetTransmissionById(int id)
    {
        return _transmissionDal.GetById(id);
    }

    public void AddTransmission(Transmission transmission)
    {
        _transmissionDal.Add(transmission);
    }
}