using aula_wpf_14_04_2020.Infraestrutura.Repositorio.Interfaces;
using aula_wpf_14_04_2020.Infraestrutura.Repositorio.Repositorios;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_wpf_14_04_2020.Infraestrutura.IoC
{
    internal static class UnitOfWorkInstaller
    {
        internal static Container Factory(Container container)
        {
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Singleton);

            return container;
        }
    }
}