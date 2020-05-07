using aula_wpf_14_04_2020.Infraestrutura.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_wpf_14_04_2020.Infraestrutura.Repositorio.Migrations
{
    internal sealed class Configurations : DbMigrationsConfiguration<DataContext>
    {
        public Configurations()
        {
            AutomaticMigrationsEnabled = false;
        }
    }
}
