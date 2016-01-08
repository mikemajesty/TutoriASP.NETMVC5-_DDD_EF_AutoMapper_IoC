using ProjetoModel.Domain.Entities;
using ProjetoModel.Domain.Services;
using ProjetoModelo.Application.Interface;
using System.Collections.Generic;

namespace ProjetoModelo.Application
{
    public class ClientAppService : AppServiceBase<Client>, IClientAppService
    {
        private readonly IClientService _clientService;
        public ClientAppService(IClientService clientService)
            : base(clientService)
        {
            this._clientService = clientService;
        }

        public IEnumerable<Client> GetSpecialClient(IEnumerable<Client> client)
        {
            return _clientService.GetSpecialClient(_clientService.GetAll());
        }
    }
}
