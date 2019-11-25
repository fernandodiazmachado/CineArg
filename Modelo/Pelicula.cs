using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocio
{
    public class Pelicula
    {
        public string Nombre { get; set; }
        public DateTime TiempoDesde { get; set; }
        public DateTime TiempoHasta { get; set; }
        public string Estreno { get; set; }

        public static string Agregar(Pelicula pelicula)
        {
            bool ok = DatosPelicula.Agregar(pelicula.Nombre, pelicula.TiempoDesde, pelicula.TiempoHasta, pelicula.Estreno);

            if (ok)
                return "Se ha dado de alta la pelicula " + pelicula.Nombre;
            else
                return "No se ha podido dar de alta la pelicula " + pelicula.Nombre;
        }

        public static DataTable Consultar()
        {
            DataTable dt = new DataTable();
            dt = DatosPelicula.ConsultarTabla();

            return dt;
        }

        public static DataTable CargarComboPelicula()
        {
            DataTable dt = new DataTable();
            dt = DatosPelicula.CargarComboPelicula();

            return dt;
        }

        public static DateTime ConsultarFechaHasta(int idPelicula)
        {
            DateTime fecha = new DateTime();
            fecha = DatosPelicula.ConsultarFechaHasta(idPelicula);

            return fecha;
        }
        public static DateTime ConsultarFechaDesde(int idPelicula)
        {
            DateTime fecha = new DateTime();
            fecha = DatosPelicula.ConsultarFechaDesde(idPelicula);

            return fecha;
        }
    }
}
