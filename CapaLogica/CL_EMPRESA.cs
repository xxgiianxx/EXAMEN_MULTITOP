using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{    /// <summary>
     ///  Clase que se conecta  a la capa datos utilizando la clase CD_EMPRESA();
     /// </summary>
    public class CL_EMPRESA
    {
        private CD_EMPRESA CD_EMPRESA = new CD_EMPRESA();

        /// <summary>
        ///  llamamos el metdo GUARDAR_EMPRESA_DIRECCION de la capa datos
        /// </summary>
        public void INSERTA_EMPRESA_DIRECCION(EMPRESA empresa,List<DIRECCION_EMPRESA> direccion)   
        {
            try 
            {
                CD_EMPRESA.GUARDAR_EMPRESA_DIRECCION(empresa,direccion);
            }catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///  llamamos el metdo CODIGO_AUTOGENERADO de la capa datos
        /// </summary>
        public string CODIGO_AUTOGENERADO()
        { string codigo = "";
            try
            {
              codigo=CD_EMPRESA.CODIGO_AUTOGENERADO();
            }
            catch (Exception)
            {
                throw;
            }    
            return codigo;

        }

        /// <summary>
        ///  llamamos el metdo LISTA de la capa datos
        /// </summary>
        public DataSet  LISTA(string codigo)
        {
            DataSet ds = null;
            try
            {
                ds = CD_EMPRESA.LISTA(codigo);
            }
            catch (Exception)
            {
                throw;
            }
            return ds;

        }
        /// <summary>
        ///  llamamos el metdo ELIMINAR_EMPRESA de la capa datos
        /// </summary>
        public void  ELIMINAR(string codigo)
        {
            try
            {
               CD_EMPRESA.ELIMINAR_EMPRESA(codigo);
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
