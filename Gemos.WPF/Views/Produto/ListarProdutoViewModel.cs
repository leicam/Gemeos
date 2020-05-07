using Gemos.WPF.Models.Produto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemos.WPF.Views.Produto
{
    public class ListarProdutoViewModel : AbstractViewModel
    {
        private ObservableCollection<ProdutoModel> _produtos = new ObservableCollection<ProdutoModel>();
        private ProdutoModel _produtoSelecionado = new ProdutoModel();

        public ObservableCollection<ProdutoModel> Produtos
        {
            get => _produtos;
            set => SetField(ref _produtos, value);
        }

        public ProdutoModel ProdutoSelecionado
        {
            get => _produtoSelecionado;
            set => SetField(ref _produtoSelecionado, value);
        }

        public CadastrarProdutoListagemCommand CadastrarProduto { get; private set; } = new CadastrarProdutoListagemCommand();
        public AlterarProdutoListagemCommand AlterarProduto { get; private set; } = new AlterarProdutoListagemCommand();

        public void RecarregarProdutos()
        {
            Produtos.Clear();

            Connector
                .ProdutoConnector
                .GetAll()
                .ToList()
                .ForEach(x => { Produtos.Add(new ProdutoModel(x.Descricao, x.Valor)); });
        }
    }
}
