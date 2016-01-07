using System.Collections.Generic;

namespace ProjetoModel.Domain.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        int Add(TEntity entity);
        TEntity GetByID(int id);
        IEnumerable<TEntity> GetAll();
        int Update(TEntity entity);
        int Remove(TEntity entity);
        void Dispose();

    }
}
