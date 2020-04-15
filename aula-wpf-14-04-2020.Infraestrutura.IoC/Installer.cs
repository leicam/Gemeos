using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_wpf_14_04_2020.Infraestrutura.IoC
{
    public static class Installer
    {
        public static Container Factory()
        {
            var container = new Container();

            container = RepositorioInstaller.Factory(container);
            container = UnitOfWorkInstaller.Factory(container);

            container.Verify();

            return container;
        }
    }
}
