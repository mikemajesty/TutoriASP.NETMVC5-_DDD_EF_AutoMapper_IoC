using ProjetoModel.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;

namespace ProjetoModel.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable,IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }
        public int Add(TEntity entity)
        {
          return  _repository.Add(entity);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetByID(int id)
        {
            return _repository.GetByID(id);
        }

        public int Remove(TEntity entity)
        {
            return _repository.Remove(entity);
        }

        public int Update(TEntity entity)
        {
          return  _repository.Update(entity);
        }
    }
}
