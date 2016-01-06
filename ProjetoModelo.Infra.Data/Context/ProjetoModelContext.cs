using ProjetoModel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModelo.Infra.Data.Context
{
    public class ProjetoModelContext : DbContext
    {
        public ProjetoModelContext() : base("ProjetoModeloDDD") { }

        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(c => c.Name == $"{c.ReflectedType.Name}ID")
                .Configure(c => c.IsKey());

            modelBuilder.Properties<String>().Configure(c => c.HasColumnType("varchar"));
            modelBuilder.Properties<String>().Configure(c => c.HasMaxLength(100));
        }
        public override int SaveChanges()
        {
            ChangeTracker.Entries<Client>()
                .Where(c => c.Entity.GetType()
                .GetProperty(nameof(Client.DateRegister)) != null)
                .ToList().ForEach(c =>
                {
                    if (c.State == EntityState.Modified)
                    {
                        c.Property(nameof(Client.DateRegister)).IsModified = false;
                    }

                });
            return base.SaveChanges();
        }
    }
}
