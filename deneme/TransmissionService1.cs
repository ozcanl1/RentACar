public class TransmissionService
{
    private InMemoryDal<Transmission> _transmissionDal;

    public TransmissionService()
    {
        _transmissionDal = new InMemoryDal<Transmission>();
    }

    public void AddTransmission(Transmission transmission)
    {
        if (!HasDuplicateName(transmission.Name))
        {
            _transmissionDal.Add(transmission);
            Console.WriteLine("Transmission added: " + transmission.Name);
        }
        else
        {
            Console.WriteLine("Transmission with the same name already exists: " + transmission.Name);
        }
    }


    public bool HasDuplicateName(string name)
    {
        return _transmissionDal.GetAll().Any(t => t.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }


}
