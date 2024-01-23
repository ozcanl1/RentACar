using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;
internal class EfModelDal : IModelDal
{
    public void Add(Model entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Model entity)
    {
        throw new NotImplementedException();
    }

    public Model? Get(Func<Model, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public Model? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public IList<Model> GetList()
    {
        throw new NotImplementedException();
    }

    public IList<Model> GetList(Func<Model, bool>? predicate = null)
    {
        throw new NotImplementedException();
    }

    public void Update(Model entity)
    {
        throw new NotImplementedException();
    }

    Model IEntityRepository<Model, int>.Add(Model entity)
    {
        throw new NotImplementedException();
    }

    Model IEntityRepository<Model, int>.Delete(Model entity)
    {
        throw new NotImplementedException();
    }

    Model IEntityRepository<Model, int>.Update(Model entity)
    {
        throw new NotImplementedException();
    }
}
