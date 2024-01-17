using Core.DataAccess;
using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryFuelDal : InMemoryEntityRepositoryBase<Fuel, int>, IFuelDal
    {
        protected override int generateId()
        {
            int nextId = _entities.Count == 0
                ? 1
                : _entities.Max(e => e.Id) + 1;
            return nextId;
        }
        //public void Add(Fuel entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(Fuel entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Fuel entity)
        //{
        //    throw new NotImplementedException();
        //}

        //Fuel? IEntityRepository<Fuel, int>.GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //IList<Fuel> IEntityRepository<Fuel, int>.GetList()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
