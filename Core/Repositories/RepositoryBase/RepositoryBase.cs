using Core.IRepositories.IBase;
using Entities.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.RepositoryBase
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : EntityBase
    {
        public T Create(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> CreateMany(IEnumerable<T> entityEnum)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public T Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }

        public T Update(T oldEntity, T newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
