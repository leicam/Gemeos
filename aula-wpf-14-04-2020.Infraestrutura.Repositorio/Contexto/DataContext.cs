using aula_wpf_14_04_2020.Infraestrutura.Repositorio.Conexao;
using MySql.Data.EntityFramework;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_wpf_14_04_2020.Infraestrutura.Repositorio.Contexto
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DataContext : GemeosContext
    {
        public DataContext() : base(MySqlConnectionManager.New().GetConnection() as MySqlConnection)
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
            Database.SetInitializer(new DataInitializer());
        }
    }
}