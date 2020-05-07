using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_wpf_14_04_2020.Infraestrutura.Repositorio.Conexao
{
    public class MySqlConnectionManager : AbstractConnection
    {
        private MySqlConnectionManager() { }

        public static MySqlConnectionManager New() => new MySqlConnectionManager();

        public override object GetConnection()
            => new MySqlConnection($"Server=localhost;" + 
                $"Database=Gemeos" + 
                $"Uid=root" +
                $"Pwd=root");
    }
}