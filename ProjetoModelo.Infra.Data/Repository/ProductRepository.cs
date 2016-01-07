using ProjetoModel.Domain.Entities;
using ProjetoModel.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModelo.Infra.Data.Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> FindByName(string name)
        {
            return _context.Products.Where(c => c.Nome == name);
        }
    }
}
