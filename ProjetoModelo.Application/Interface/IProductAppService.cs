using ProjetoModel.Domain.Entities;
using ProjetoModelo.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModelo.Application.Interface
{
    public interface IProductAppService : IAppServiceBase<Product>
    {
        IEnumerable<Product> FindByName(string nome);
    }
}
