using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datos
{
    public class DatosDescuento
    {
        public static DataTable ConsultarTabla()
        {
            Conexion con = new Conexion();
            string query = "SELECT * FROM cinearg.descuentos;";
            return con.SelectDataTable(query);
        }

        public static int ConsultarPorcentajePorId(int id)
        {
            Conexion con = new Conexion();
            string query = "SELECT porcentaje FROM cinearg.descuentos ";
            query = query + "WHERE idDescuentos = " + id;
            return con.TraerInt(query);
        }

        public static bool Modificar(int idDescuentos, double porcentaje)
        {
            Conexion con = new Conexion();
            string query = "UPDATE `descuentos` SET `porcentaje` = '" + porcentaje + "' ";
            query = query + "WHERE (`idDescuentos` = '" + idDescuentos + "');";
            return con.ExecuteComand(query);
        }
    }
}
