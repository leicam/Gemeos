using aula_wpf_14_04_2020.Infraestrutura.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_wpf_14_04_2020.Infraestrutura.Repositorio.Repositorios
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepositorioProduto RepositorioProduto { get; }

        public UnitOfWork(IRepositorioProduto repositorioProduto)
        {
            RepositorioProduto = repositorioProduto;
        }
    }
}