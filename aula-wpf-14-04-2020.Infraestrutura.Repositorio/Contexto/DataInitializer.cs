using aula_wpf_14_04_2020.Infraestrutura.Repositorio.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_wpf_14_04_2020.Infraestrutura.Repositorio.Contexto
{
    internal class DataInitializer : MigrateDatabaseToLatestVersion<DataContext, Configurations> { }
}
