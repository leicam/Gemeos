using aula_wpf_14_04_2020.Dominio.Entidades;
using aula_wpf_14_04_2020.Infraestrutura.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemos.WPF.Connectors
{
    public class ProdutoConnector
    {
        private readonly IRepositorioProduto _repositorioProduto;

        public ProdutoConnector(IUnitOfWork unitOfWork)
        {
            _repositorioProduto = unitOfWork?.RepositorioProduto;
        }

        public void Add(Produto produto)
        {
            _repositorioProduto.AddOrUpdate(produto);
            _repositorioProduto.SaveChanges();
        }

        public IEnumerable<Produto> GetAll() => _repositorioProduto.GetAll();
    }
}
