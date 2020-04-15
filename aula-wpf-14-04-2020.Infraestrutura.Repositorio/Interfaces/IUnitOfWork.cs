using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_wpf_14_04_2020.Infraestrutura.Repositorio.Interfaces
{
    public interface IUnitOfWork
    {
        IRepositorioProduto RepositorioProduto { get; }
    }
}