using System;
using System.Collections.Generic;
using System.Linq;

public class InMemoryTransmissionDal
{
    private static List<Transmission> transmissions = new List<Transmission>();

    public List<Transmission> GetAll()
    {
        return transmissions;
    }

    public Transmission GetById(int id)
    {
        return transmissions.Find(t => t.Id == id);
    }

    public void Add(Transmission transmission)
    {
        if (transmissions.Any(t => t.Name == transmission.Name))
        {

            throw new InvalidOperationException("Aynı isimde bir şanzıman türü zaten var.");
        }

        transmissions.Add(transmission);
    }

    public void Update(Transmission transmission)
    {
   
    }

    public void Delete(int id)
    {
        transmissions.RemoveAll(t => t.Id == id);
    }
}
