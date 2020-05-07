using Gemos.WPF.Classes;
using Gemos.WPF.Views.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemos.WPF.Views.MainWindow
{
    public class ListarProdutoMainWindowComand : AbstractCommand
    {
        public override void Execute(object parameter)
        {
            ucListarProduto.Listar();
        }
    }
}
