using ProjetoModel.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModelo.Application.Interface
{
    public interface IProductAppService : IAppServiceBase<Product>
    {
        IEnumerable<Product> FindByName(string nome);
    }
}
