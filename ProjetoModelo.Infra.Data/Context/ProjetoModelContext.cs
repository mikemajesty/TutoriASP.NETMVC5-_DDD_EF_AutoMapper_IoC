using ProjetoModel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModelo.Infra.Data.Context
{
    public class ProjetoModelContext : DbContext
    {
        public ProjetoModelContext() : base("ProjetoModeloDDD") { }

        public DbSet<Client> Clients { get; set; }

    }
}
