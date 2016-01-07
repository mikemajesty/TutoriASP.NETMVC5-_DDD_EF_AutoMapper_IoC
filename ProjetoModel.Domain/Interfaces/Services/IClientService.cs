using ProjetoModel.Domain.Entities;
using System.Collections.Generic;
namespace ProjetoModel.Domain.Services
{
    public interface IClientService : IServiceBase<Client>
    {
        IEnumerable<Client> GetSpecialClient(IEnumerable<Client> client);
    }
}
