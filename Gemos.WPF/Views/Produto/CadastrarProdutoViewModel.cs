using Gemos.WPF.Models.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemos.WPF.Views.Produto
{
    public class CadastrarProdutoViewModel : AbstractViewModel
    {
        private ProdutoModel _produto = new ProdutoModel();

        public ProdutoModel Produto
        {
            get => _produto;
            set => SetField(ref _produto, value);
        }

        public CadastrarProdutoViewModel() { }

        public CadastrarProdutoViewModel(ProdutoModel produto)
        {
            Produto = produto;
        }

        public CadastrarProdutoCommand CadastrarProduto { get; private set; } = new CadastrarProdutoCommand();
    }
}