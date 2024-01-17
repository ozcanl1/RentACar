public class InMemoryGearboxDal
{
    private static List<Gearbox> gearboxes;

    static InMemoryGearboxDal()
    {
        gearboxes = new List<Gearbox>
        {
            new Gearbox { Id = 1, Type = "Automatic" },
            new Gearbox { Id = 2, Type = "Manual" },
        };
    }

    public List<Gearbox> GetAll()
    {
        return gearboxes;
    }

    public Gearbox GetById(int id)
    {
        return gearboxes.FirstOrDefault(g => g.Id == id);
    }

    public void Add(Gearbox gearbox)
    {
        if (gearboxes.Any(g => g.Type == gearbox.Type))
        {
            throw new InvalidOperationException("");
        }

        gearbox.Id = gearboxes.Count + 1;
        gearboxes.Add(gearbox);
    }
}
