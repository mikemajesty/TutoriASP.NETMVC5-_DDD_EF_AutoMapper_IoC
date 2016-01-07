using ProjetoModel.Domain.Interfaces.Repository;
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
        protected readonly ProjetoModelContext _context = new ProjetoModelContext();
       // protected DbSet<TEntity> _dbSet;
        //public RepositoryBase()
        //{
        //    _context = new ProjetoModelContext();
        //    _dbSet = _context.Set<TEntity>();
        //}
        public int Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            return SaveChanges();
        }

        public void Dispose()
        {
            this._context.Dispose();
            //this._dbSet = null;
        }

        public IEnumerable<TEntity> GetAll()
        {
           return _context.Set<TEntity>().ToList();
        }

        public TEntity GetByID(int id)
        {
            return _context.Set<TEntity>().Find(id);

        }

        public int Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            return SaveChanges();
        }

        public int Update(TEntity entity)
        {
            _context.Entry<TEntity>(entity).State = EntityState.Modified;
            return SaveChanges();
        }

        private int SaveChanges()
        {
            return _context.SaveChanges();
        }

       
    }
}
