using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosPelicula
    {
        public static bool Agregar(string nombre, DateTime desde, DateTime hasta)
        {
            Conexion con = new Conexion();
            string query = "INSERT INTO PELICULAS (nombre, fechadesde, fechahasta) ";
            query = query + "VALUES ('" + nombre + "', '" + desde.ToString("yyyy-MM-dd H:mm:ss") + "', '" + hasta.ToString("yyyy-MM-dd H:mm:ss") + "')";
            return con.ExecuteComand(query);
        }
    }
}
