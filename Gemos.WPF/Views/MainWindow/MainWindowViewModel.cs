using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemos.WPF.Views.MainWindow
{
    public class MainWindowViewModel : AbstractViewModel
    {
        public ListarProdutoMainWindowComand ListarProduto { get; private set; } = new ListarProdutoMainWindowComand();
    }
}
