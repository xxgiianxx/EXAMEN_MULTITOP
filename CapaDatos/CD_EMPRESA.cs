using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{    /// <summary>
     /// Clase donde se realiza la conexion a la base de datos  e implementa la interfaz  CD_IEMPRESA
     /// </summary>
    public class CD_EMPRESA : CD_IEMPRESA
    {

        /// <summary>
        /// Define variales publicas 
        /// </summary>
        private CD_CONEXION conexion = new CD_CONEXION();
        SqlCommand comand = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();


        /// <summary>
        /// Evento que obtiene el codigo autogenerado
        /// </summary>
        public string CODIGO_AUTOGENERADO()
        {
            string resut = "";
            try
            {
                comand.Parameters.Clear();
                comand.Connection = conexion.AbrirConexion();
                comand.CommandText = "SP_GENERA_CODIGO";
                comand.CommandType = CommandType.StoredProcedure;
                resut = comand.ExecuteScalar().ToString();
                conexion.CerrarConexion();
                           }
            catch (Exception)
            {

                throw;
            }
                       return resut;
        }

        /// <summary>
        /// Evento que valida si la ruc,razon social existe
        /// </summary>
        public string VALIDA_EMPRESA(string ruc,string razon_social)
        {
            string result = "";
            try
            {
                comand.Parameters.Clear();
                comand.Connection = conexion.AbrirConexion();
                comand.CommandText = "SP_VALIDA_EMPRESA";
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.AddWithValue("@vRuc", ruc);
                comand.Parameters.AddWithValue("@vRazonSocial", razon_social);
                result = Convert.ToString(comand.ExecuteScalar());
                conexion.CerrarConexion();

            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }
        /// <summary>
        /// Evento que guardar la  empresa  y direccion
        /// </summary>
        public void GUARDAR_EMPRESA_DIRECCION(EMPRESA empresa, List<DIRECCION_EMPRESA> direccion)
        {
            SqlTransaction transaction = null;
            try
            {
                comand.Parameters.Clear();
                /// <summary>
                /// valida si la ruc y razon social  ya existe
                /// </summary>
                string valida = VALIDA_EMPRESA(empresa.Ruc, empresa.Razon_Social);
                if (valida == "RR")
                {
                    throw new Exception("El ruc  y Razon Social ya Existe");
                }
                else if (valida == "RU")
                {
                    throw new Exception("El ruc  ya Existe");
                }
                else if (valida == "RA") {
                    throw new Exception("La Razon Social  ya Existe");
                }
                                comand.Parameters.Clear();

                comand.Connection = conexion.AbrirConexion();    
                transaction = conexion.BeginTransaction();
                comand.CommandText = "SP_GUARDA_EMPRESA";
                comand.Transaction = transaction;
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.AddWithValue("@vCodigo", empresa.Codigo);
                comand.Parameters.AddWithValue("@vRuc", empresa.Ruc);
                comand.Parameters.AddWithValue("@vRazonSocial", empresa.Razon_Social);
                comand.Parameters.AddWithValue("@bEstado", empresa.Estado);
                comand.ExecuteNonQuery();
                /// <summary>
                /// recorre la lista de direcciones
                /// </summary>
                foreach (var item in direccion)
                {
                    comand.Parameters.Clear();
                    comand.CommandText = "SP_GUARDA_EMPRESA_DIRECCION";
                    comand.Transaction = transaction;
                    comand.Parameters.AddWithValue("@vCodigo", item.Codigo);
                    comand.Parameters.AddWithValue("@vDireccion", item.Direccion);
                    comand.ExecuteNonQuery();
                }
                /// <summary>
                /// si guardo con exito ejecuta el commit
                /// </summary>
                transaction.Commit();
                /// <summary>
                ///  cierra conexion
                /// </summary>
                conexion.CerrarConexion();

            }
            catch (Exception)
            {              
                comand.Dispose();
                if (transaction != null) transaction.Rollback();
                throw;
            }


        }
        /// <summary>
        ///  Evento que elimina la direccion y empresa segun ruc digitado
        /// </summary>
        public void ELIMINAR_EMPRESA(string CODIGO)
        {
            SqlTransaction transaction = null;

            try
            {
                comand.Parameters.Clear();
                /// <summary>
                ///  llama al metodo existe empresa
                /// </summary>
                int existe = EXISTE_EMPRESA(CODIGO);
                if (existe == 0)
                {
                    /// <summary>
                    ///   envio un exception al no existir empresa
                    /// </summary>
                    throw new Exception("La Empresa no existe");
                }
                comand.Parameters.Clear();
                comand.Connection = conexion.AbrirConexion();
                transaction = conexion.BeginTransaction();
                comand.CommandText = "SP_ELIMINA_EMPRESA";
                comand.Transaction = transaction;
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.AddWithValue("@vCodigo", CODIGO);
                comand.ExecuteNonQuery();
                transaction.Commit();
                conexion.CerrarConexion();

            }
            catch (Exception)
            {
                comand.Dispose();
                if (transaction != null) transaction.Rollback();
                throw;
            }


        }
        /// <summary>
        ///  Evento que lista la direccion y empresa segun ruc digitado retorna un dataset
        /// </summary>
        public DataSet LISTA(string codigo)
        {
            comand.Parameters.Clear();
            DataSet ds = new DataSet();
            comand.Connection = conexion.AbrirConexion();
            comand.CommandText = "SP_LISTA_DATOS";
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.AddWithValue("@vCodigo", codigo);
            adapter = new SqlDataAdapter (comand);
            ds = new DataSet();
            adapter.Fill(ds);
            /// <summary>
            ///  Define nombre de cada table que esta en el dataset
            /// </summary>
            ds.Tables[0].TableName = "DETALLE";
            ds.Tables[1].TableName = "CABECERA";
            /// <summary>
            ///  cierra la conexion
            /// </summary>
            conexion.CerrarConexion();

            return ds;
        }
        /// <summary>
        ///  Evento que valida si la empresa digitada existe
        /// </summary>
        public int EXISTE_EMPRESA(string CODIGO)
        {
            int resut = 0;
            try
            {
                comand.Parameters.Clear();
                comand.Connection = conexion.AbrirConexion();
                comand.CommandText = "SP_EXISTE_EMPRESA";
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.AddWithValue("@vCodigo", CODIGO);
                resut = Convert.ToInt32(comand.ExecuteScalar());
                conexion.CerrarConexion();
            }
            catch (Exception)
            {

                throw;
            }
            return resut;
        }
    }
}
