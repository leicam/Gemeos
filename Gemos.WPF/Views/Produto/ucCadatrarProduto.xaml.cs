using Gemos.WPF.Models.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Gemos.WPF.Views.Produto
{
    public partial class ucCadatrarProduto : Window
    {
        private ucCadatrarProduto()
        {
            InitializeComponent();
            DataContext = new CadastrarProdutoViewModel();
        }

        private ucCadatrarProduto(ProdutoModel produto)
        {
            InitializeComponent();
            DataContext = new CadastrarProdutoViewModel(produto);
        }

        public static void Cadastrar()
        {
            var janela = new ucCadatrarProduto();
            janela.ShowDialog();
        }

        public static void Alterar(ProdutoModel produto)
        {
            var janela = new ucCadatrarProduto(produto);
            janela.ShowDialog();
        }
    }
}
