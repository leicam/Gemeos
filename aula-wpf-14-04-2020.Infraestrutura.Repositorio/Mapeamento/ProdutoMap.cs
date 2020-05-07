using aula_wpf_14_04_2020.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_wpf_14_04_2020.Infraestrutura.Repositorio.Mapeamento
{
    internal class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            ToTable("PRODUTO");

            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("CD_PRODUTO").IsRequired();
            Property(x => x.Descricao).HasColumnName("DS_PRODUTO").IsRequired();
            Property(x => x.Valor).HasColumnName("VL_PRODUTO").IsRequired();
        }
    }
}