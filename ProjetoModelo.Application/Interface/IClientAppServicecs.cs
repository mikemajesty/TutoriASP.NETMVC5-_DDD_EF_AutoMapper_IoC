using ProjetoModel.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModelo.Application.Interface
{
    public interface IClientAppServicecs : IAppServiceBase<Client>
    {
        IEnumerable<Client> GetSpecialClient(IEnumerable<Client> client);
    }
}
