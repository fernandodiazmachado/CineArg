using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosDescuento
    {
        public static bool ConsultarTabla()
        {
            Conexion con = new Conexion();
            string query = "SELECT * FROM cinearg.descuentos;";
            return con.ExecuteComand(query);
        }
        public static bool Modificar(int idDescentos, string detalle, int porcentaje)
        {
            Conexion con = new Conexion();
            string query = "UPDATE `descuentos` SET `porcentaje` = '" + porcentaje + "' ";
            query = query + "WHERE (`idDescuentos` = '" + idDescentos + "');";
            return con.ExecuteComand(query);
        }
    }
}
