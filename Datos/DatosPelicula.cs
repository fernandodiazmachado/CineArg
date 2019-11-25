using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datos
{
    public class DatosPelicula
    {
        public static DataTable ConsultarTabla()
        {
            Conexion con = new Conexion();
            string query = "SELECT * FROM cinearg.peliculas;";
            return con.SelectDataTable(query);
        }

        public static DataTable CargarComboPelicula()
        {
            Conexion con = new Conexion();
            string query = "SELECT idPelicula, nombre FROM peliculas ";
            query += "union select 0, 'TODAS' ORDER BY 1";
            return con.SelectDataTable(query);
        }

        public static bool Agregar(string nombre, DateTime desde, DateTime hasta, string estreno)
        {
            Conexion con = new Conexion();
            string query = "INSERT INTO PELICULAS (nombre, fechadesde, fechahasta, estreno) ";
            query = query + "VALUES ('" + nombre + "', '" + desde.ToString("yyyy-MM-dd H:mm:ss") + "', '" + hasta.ToString("yyyy-MM-dd H:mm:ss") + "','" + estreno + "')";
            return con.ExecuteComand(query);
        }

        public static DateTime ConsultarFechaHasta(int idPelicula)
        {
            Conexion con = new Conexion();
            string query = "SELECT fechaHasta FROM cinearg.peliculas ";
            query += "WHERE idPelicula = " + idPelicula ;
            return DateTime.Parse(con.TraerString(query));
        }

        public static DateTime ConsultarFechaDesde(int idPelicula)
        {
            Conexion con = new Conexion();
            string query = "SELECT fechaDesde FROM cinearg.peliculas ";
            query += "WHERE idPelicula = " + idPelicula;
            return DateTime.Parse(con.TraerString(query));
        }
    }
}
