using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    /// <summary>
    /// Clase conexion se esta utilizando el patron singleton una sola instancia
    /// </summary>
    class ConexionSql
    {
        private static readonly Lazy<ConexionSql> lazy =
         new Lazy<ConexionSql>(() => new ConexionSql());

        public static ConexionSql Instance { get { return lazy.Value; } }

        private SqlConnection connection;

        private ConexionSql()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=PRUEBA;Integrated Security = True;encrypt=false;";
            connection = new SqlConnection(connectionString);
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }




    }
}
