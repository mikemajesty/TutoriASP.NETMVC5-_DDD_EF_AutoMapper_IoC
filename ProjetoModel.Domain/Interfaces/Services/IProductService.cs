using ProjetoModel.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModel.Domain.Services
{
    public interface IProductService : IServiceBase<Product>
    {
        IEnumerable<Product> FindByName(string nome);
    }
}
