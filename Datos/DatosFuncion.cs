using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosFuncion
    {
        public static bool Agregar(int idPelicula, int idSala, int idIdioma, DateTime fechaProy)
        {
            Conexion con = new Conexion();
            string query = "INSERT INTO FUNCION (FK_Pelicula, Fk_Sala,Fk_Idioma,fechaProyeccion) ";
            query = query + "VALUES ('" + idPelicula + "', '" + idSala + "', '"+ idIdioma + "', '"+ fechaProy.ToString("yyyy-MM-dd HH:mm:00") + "')";
            return con.ExecuteComand(query);
        }
    }
}
