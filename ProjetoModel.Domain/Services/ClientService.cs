using System.Collections.Generic;
using ProjetoModel.Domain.Entities;
using ProjetoModel.Domain.Interfaces.Repository;
using System.Linq;
using System;

namespace ProjetoModel.Domain.Services
{
    public class ClientService : ServiceBase<Client>, IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository repository) : base(repository)
        {
            _clientRepository = repository;
        }

        public IEnumerable<Client> GetSpecialClient(IEnumerable<Client> clients)
        {
            return clients.Where(c=>c.SpecialClient(c));
        }
    }
}
