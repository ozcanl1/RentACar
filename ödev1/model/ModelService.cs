public class ModelService
{
    private readonly InMemoryModelDal _modelDal;

    public ModelService(InMemoryModelDal modelDal)
    {
        _modelDal = modelDal;
    }

    public List<Model> GetAllModels()
    {
        return _modelDal.GetAll();
    }

    public Model GetModelById(int id)
    {
        return _modelDal.GetById(id);
    }

    public void AddModel(Model model)
    {
        _modelDal.Add(model);
    }
}
