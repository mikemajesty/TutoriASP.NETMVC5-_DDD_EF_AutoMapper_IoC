using System.Collections.Generic;

namespace ProjetoModelo.Application.Interface
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        int Add(TEntity entity);
        int Remove(TEntity entity);
        TEntity GetByID(int id);
        IEnumerable<TEntity> GetAll();
        int Update(TEntity entity);
        void Dispose();

    }
}
