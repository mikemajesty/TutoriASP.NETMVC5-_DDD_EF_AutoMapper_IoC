using ProjetoModel.Domain.Interfaces;
using ProjetoModelo.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModelo.Infra.Data.Repository
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly ProjetoModelContext _context;
        protected DbSet<TEntity> _dbSet;
        public RepositoryBase()
        {
            _context = new ProjetoModelContext();
            _dbSet = _context.Set<TEntity>();
        }
        public int Add(TEntity entity)
        {
            _dbSet.Add(entity);
            return SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public int Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
