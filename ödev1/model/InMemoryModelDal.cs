public class InMemoryModelDal
{
    private static List<Model> models;

    static InMemoryModelDal()
    {
        models = new List<Model>
        {
            new Model { Id = 1, Name = "Togg" },
        };
    }

    public List<Model> GetAll()
    {
        return models;
    }

    public Model GetById(int id)
    {
        return models.FirstOrDefault(m => m.Id == id);
    }

    public void Add(Model model)
    {
        if (models.Any(m => m.Name == model.Name))
        {
            throw new InvalidOperationException("");
        }

        model.Id = models.Count + 1;
        models.Add(model);
    }
}
