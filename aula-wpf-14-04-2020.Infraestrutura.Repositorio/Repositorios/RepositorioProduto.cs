using aula_wpf_14_04_2020.Dominio.Entidades;
using aula_wpf_14_04_2020.Infraestrutura.Repositorio.Contexto;
using aula_wpf_14_04_2020.Infraestrutura.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_wpf_14_04_2020.Infraestrutura.Repositorio.Repositorios
{
    public class RepositorioProduto : RepositorioGenerico<Produto>, IRepositorioProduto
    {
        public RepositorioProduto(GemeosContext gemeosContext) : base(gemeosContext) { }
    }
}