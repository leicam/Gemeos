using aula_wpf_14_04_2020.Infraestrutura.IoC;
using aula_wpf_14_04_2020.Infraestrutura.Repositorio.Interfaces;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemos.WPF.Connectors
{
    public class Connector
    {
        private static Container _container;

        private Connector()
        {
            if(_container == null)
                _container = Installer.Factory();
        }

        public static Connector Factory()
        {
            return new Connector();
        }


        public ProdutoConnector ProdutoConnector { get; private set; } = new ProdutoConnector(_container?.GetInstance<IUnitOfWork>());
    }
}