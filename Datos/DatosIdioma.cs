using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datos
{
    public class DatosIdioma
    {
        public static DataTable ConsultarTabla()
        {
            Conexion con = new Conexion();
            string query = "SELECT * FROM cinearg.idiomas;";
            return con.SelectDataTable(query);
        }
    }
}
