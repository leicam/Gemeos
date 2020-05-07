using aula_wpf_14_04_2020.Dominio.Entidades;
using aula_wpf_14_04_2020.Infraestrutura.Repositorio.Mapeamento;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_wpf_14_04_2020.Infraestrutura.Repositorio.Contexto
{
    public abstract class GemeosContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public GemeosContext(DbConnection dbConnection) : base (dbConnection, true) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutoMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
