public class InMemoryFuelDal
{
    private static List<Fuel> fuels;

    static InMemoryFuelDal()
    {
        fuels = new List<Fuel>
        {
            new Fuel { Id = 1, Name = "Gasoline" },
            new Fuel { Id = 2, Name = "Diesel" },
        };
    }

    public List<Fuel> GetAll()
    {
        return fuels;
    }

    public Fuel GetById(int id)
    {
        return fuels.FirstOrDefault(f => f.Id == id);
    }

    public void Add(Fuel fuel)
    {
        if (fuels.Any(f => f.Name == fuel.Name))
        {
            throw new InvalidOperationException("Aynı isimde fuel zaten mevcut!");
        }

        fuel.Id = fuels.Count + 1;
        fuels.Add(fuel);
    }


}