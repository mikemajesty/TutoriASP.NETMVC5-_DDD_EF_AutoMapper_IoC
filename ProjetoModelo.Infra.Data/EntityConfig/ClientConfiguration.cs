using ProjetoModel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModelo.Infra.Data.EntityConfig
{
    public class ClientConfiguration : EntityTypeConfiguration<Client>
    {
        public ClientConfiguration()
        {
            Property(c => c.Name).IsRequired().HasMaxLength(50);
            Property(c => c.LastName).IsRequired().HasMaxLength(50);
            Property(c=>c.Email).IsRequired();
            
        }
    }
}
