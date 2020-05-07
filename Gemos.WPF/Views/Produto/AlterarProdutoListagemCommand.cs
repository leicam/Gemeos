using Gemos.WPF.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemos.WPF.Views.Produto
{
    public class AlterarProdutoListagemCommand : AbstractCommand
    {
        public override void Execute(object parameter)
        {
            ucCadatrarProduto.Alterar((parameter as ListarProdutoViewModel).ProdutoSelecionado);
        }
    }
}
