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

        public static int ObtenerDescuentoMaximo(int descuentoMaximo)
        {
            Conexion con = new Conexion();

            string descuentos = "";
            switch (descuentoMaximo)
            {
               case 1:
                    descuentos = "1,3,4,5"; //Estreno - FIN DE SEMANA - 2D - 2D ULTIMAS 10
                    break;
                case 2:
                    descuentos = "1,3,6,7"; //ESTRENO - FIN DE SEMANA - 3D - 3D PRIMERAS 10
                    break;
                case 3:
                    descuentos = "1,2,4,5"; //ESTRENO - SEMANA - 2D - 2D ULTIMAS 10
                    break;
                case 4:
                    descuentos = "1,2,6,7"; //ESTRENO - SEMANA - 3D - 3D PRIMERAS 10
                    break;
            }

            string query = "SELECT SUM(porcentaje) FROM cinearg.descuentos ";
            query = query + "WHERE idDescuentos in (" + descuentos + ")";
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
