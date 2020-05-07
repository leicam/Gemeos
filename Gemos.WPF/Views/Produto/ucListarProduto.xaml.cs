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
    /// <summary>
    /// Lógica interna para ucListarProduto.xaml
    /// </summary>
    public partial class ucListarProduto : Window
    {
        private ucListarProduto()
        {
            InitializeComponent();
            DataContext = new ListarProdutoViewModel();
        }

        public static void Listar()
        {
            var janela = new ucListarProduto();
            janela.ShowDialog();
        }
    }
}
