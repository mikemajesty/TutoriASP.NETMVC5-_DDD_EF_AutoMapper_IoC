using ProjetoModel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModel.Domain.Interfaces
{
    public interface IProductRepository : IRepositoryBase<Product> 
    {
        IEnumerable<Product> FindByName(string name);
       
    }
}
