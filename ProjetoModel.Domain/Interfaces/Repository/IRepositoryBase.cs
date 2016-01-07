using System.Collections.Generic;

namespace ProjetoModel.Domain.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        int Add(TEntity entity);
        int Remove(TEntity entity);
        TEntity GetByID(int id);
        IEnumerable<TEntity> GetAll();
        int Update(TEntity entity);
        void Dispose();
       
    }
}
