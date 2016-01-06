using System;
using System.Collections.Generic;

namespace ProjetoModel.Domain.Entities
{
    public class Client
    {
        public int ClientID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateRegister { get; set; } = DateTime.Now;
        public bool Ativo { get; set; }
        public IEnumerable<Product> Product { get; set; }
        public bool SpecialClient(Client client)
        {
            return client.Ativo && DateTime.Now.Year - client.DateRegister.Year >= 5;
        }

        
    }
}
