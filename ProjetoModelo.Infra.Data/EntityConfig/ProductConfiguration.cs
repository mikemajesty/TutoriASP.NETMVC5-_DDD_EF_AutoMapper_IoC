using ProjetoModel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModelo.Infra.Data.EntityConfig
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            Property(c => c.Nome).IsRequired().HasMaxLength(100);
            Property(c=>c.Value).IsRequired();
            HasRequired(c=>c.Client).WithMany().HasForeignKey(c=>c.ClientID);
        }
    }
}
