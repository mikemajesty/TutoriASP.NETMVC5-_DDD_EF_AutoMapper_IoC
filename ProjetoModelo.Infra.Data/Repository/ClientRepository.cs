using ProjetoModel.Domain.Entities;
using ProjetoModel.Domain.Interfaces.Repository;

namespace ProjetoModelo.Infra.Data.Repository
{
    public class ClientRepository : RepositoryBase<Client> , IClientRepository
    {
    }
}
