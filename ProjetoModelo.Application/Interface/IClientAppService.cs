using ProjetoModel.Domain.Entities;
using ProjetoModel.Domain.Services;
using System.Collections.Generic;

namespace ProjetoModelo.Application.Interface
{
    public interface IClientAppService : IServiceBase<Client>
    {
        IEnumerable<Client> GetSpecialClient();
    }
}
