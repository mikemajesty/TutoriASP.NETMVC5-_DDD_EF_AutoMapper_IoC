using ProjetoModel.Domain.Entities;
using ProjetoModel.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModelo.Infra.Data.Repository
{
    public class ClientRepository : RepositoryBase<Client> , IClientRepository
    {
    }
}
