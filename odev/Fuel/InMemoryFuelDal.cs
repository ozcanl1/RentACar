using System.Collections.Generic;

public class InMemoryFuelDal
{
    private static List<Fuel> fuels = new List<Fuel>();

    public List<Fuel> GetAll()
    {
        return fuels;
    }

    public Fuel GetById(int id)
    {
        return fuels.Find(f => f.Id == id);
    }

    public void Add(Fuel fuel)
    {

        if (fuels.Any(f => f.Name == fuel.Name))
        {
     
            throw new InvalidOperationException("Aynı isimde bir yakıt türü zaten var.");
        }

        fuels.Add(fuel);
    }

    public void Update(Fuel fuel)
    {
     
    }

    public void Delete(int id)
    {
        fuels.RemoveAll(f => f.Id == id);
    }
}
