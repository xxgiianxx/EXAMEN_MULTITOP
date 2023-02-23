using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{    /// <summary>
     /// Interfaz que contiene los eventos realizados
     /// </summary>
    interface CD_IEMPRESA
    {

        void GUARDAR_EMPRESA_DIRECCION(EMPRESA empresa,List<DIRECCION_EMPRESA> direccion);
        string CODIGO_AUTOGENERADO();
        string VALIDA_EMPRESA(string ruc, string razon_social);
        int EXISTE_EMPRESA(string CODIGO);
        void ELIMINAR_EMPRESA(string CODIGO);
        DataSet LISTA(string codigo);
        
    }
}
