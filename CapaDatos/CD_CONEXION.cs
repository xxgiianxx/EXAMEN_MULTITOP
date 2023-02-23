using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    /// <summary>
    /// Clase donde se define los metodos de SqlConnection
    /// </summary>
    class CD_CONEXION
    {
        private SqlConnection connection = ConexionSql.Instance.GetConnection();


        public SqlConnection AbrirConexion()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            return connection;
        }


        public SqlConnection CerrarConexion()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
            return connection;
        }


        public SqlTransaction BeginTransaction()
        {
            SqlTransaction transaction = null;
            transaction = connection.BeginTransaction();
            return transaction;
        }


    }
}
