public class InMemoryTransmissionDal
{
    private static List<Transmission> transmissions;

    static InMemoryTransmissionDal()
    {
        transmissions = new List<Transmission>
        {
            new Transmission { Id = 1, Name = "Automatic" },
            new Transmission { Id = 2, Name = "Manual" },
        };
    }

    public List<Transmission> GetAll()
    {
        return transmissions;
    }

    public Transmission GetById(int id)
    {
        return transmissions.FirstOrDefault(t => t.Id == id);
    }

    public void Add(Transmission transmission)
    {
        if (transmissions.Any(t => t.Name == transmission.Name))
        {
            throw new InvalidOperationException("Aynı isimde transmission zaten mevcut!");
        }

        transmission.Id = transmissions.Count + 1;
        transmissions.Add(transmission);
    }

}