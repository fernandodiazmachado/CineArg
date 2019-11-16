using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocio
{
    public class Idioma
    {
        public int IdIdioma { get; set; }
        public string Descripcion { get; set; }

        public static DataTable Consultar()
        {
            DataTable dt = new DataTable();
            dt = DatosIdioma.ConsultarTabla();

            return dt;
        }
    }
}
