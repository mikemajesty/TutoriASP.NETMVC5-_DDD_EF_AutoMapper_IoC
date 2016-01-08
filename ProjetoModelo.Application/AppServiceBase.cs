using ProjetoModel.Domain.Services;
using ProjetoModelo.Application.Interface;
using System;
using System.Collections.Generic;

namespace ProjetoModelo.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> _serviceBase)
        {
            this._serviceBase = _serviceBase;
        }

        public int Add(TEntity entity)
        {
            return _serviceBase.Add(entity);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public TEntity GetByID(int id)
        {
            return _serviceBase.GetByID(id);
        }

        public int Remove(TEntity entity)
        {
            return _serviceBase.Remove(entity);
        }

        public int Update(TEntity entity)
        {
          return  _serviceBase.Update(entity);
        }
    }
}
