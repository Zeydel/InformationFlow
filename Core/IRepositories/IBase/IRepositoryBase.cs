using System;
using System.Collections.Generic;

namespace Core.IRepositories.IBase
{
    public interface IRepositoryBase<T>
    {
		T Get(Guid id);
		IEnumerable<T> GetAll();
		T Create(T entity);
		IEnumerable<T> CreateMany(IEnumerable<T> entityEnum);
		T Update(T entity);
		T Update(T oldEntity, T newEntity);
		void Delete(Guid id);
	}
}
