using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{    /// <summary>
     ///  clase donde se define las campos 
     /// </summary>
    public class EMPRESA
    {

        public string Codigo { get; set; }
        public string Ruc { get; set; }
        public string Razon_Social { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

    }


}
